using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Part1
{
    public class RecycleBinService
    {
        public static void SetupDataGridView(DataGridView BinGridView)
        {
            BinGridView.Columns.Clear();
            BinGridView.RowHeadersWidth = 30;
            BinGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            BinGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BinGridView.AllowUserToAddRows = false;

            // header style
            BinGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // ID column
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "ID";
            idColumn.Width = 25;
            idColumn.ReadOnly = true;
            idColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            idColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 
            BinGridView.Columns.Add(idColumn);

            // S column
            DataGridViewTextBoxColumn inputSColumn = new DataGridViewTextBoxColumn();
            inputSColumn.Name = "StringS";
            inputSColumn.HeaderText = "S";
            inputSColumn.MinimumWidth = 100;
            inputSColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            inputSColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            inputSColumn.Resizable = DataGridViewTriState.False;
  
            BinGridView.Columns.Add(inputSColumn);

            // N column
            DataGridViewTextBoxColumn inputNColumn = new DataGridViewTextBoxColumn();
            inputNColumn.Name = "NumberN";
            inputNColumn.HeaderText = "N";
            inputNColumn.Width = 25;
            inputNColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 
            BinGridView.Columns.Add(inputNColumn);

            // Time column
            DataGridViewTextBoxColumn createdAtColumn = new DataGridViewTextBoxColumn();
            createdAtColumn.Name = "Time";
            createdAtColumn.HeaderText = "Created at";
            createdAtColumn.Width = 120;
            createdAtColumn.ReadOnly = true;
            createdAtColumn.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"; 
            createdAtColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 
            createdAtColumn.DefaultCellStyle.Font = new Font("Arial", 8); 
            BinGridView.Columns.Add(createdAtColumn);

            // Dtime column
            DataGridViewTextBoxColumn deletedAtColumn = new DataGridViewTextBoxColumn();
            deletedAtColumn.Name = "DeletedTime";
            deletedAtColumn.HeaderText = "Deleted At";
            deletedAtColumn.Width = 120;
            deletedAtColumn.ReadOnly = true;
            deletedAtColumn.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"; 
            deletedAtColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 
            deletedAtColumn.DefaultCellStyle.Font = new Font("Arial", 8); 
            BinGridView.Columns.Add(deletedAtColumn);

            // header style
            BinGridView.EnableHeadersVisualStyles = false;
            BinGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            BinGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            BinGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            BinGridView.DefaultCellStyle.Font = new Font("Arial", 10);
        }
        public static void ProcessRestoration(int uniqueID, string inputText, string shiftValue, DateTime time)
        {
            StringProcessing processor = new StringProcessing(uniqueID, inputText, shiftValue, time);
            processor.Encode();
            processor.AddToHistory(uniqueID, inputText, shiftValue, time);
        }

        public static void ProcessRestoreAll()
        {
            var allDeletedItems = GetAllBinData(); 

            if (allDeletedItems == null || allDeletedItems.Count == 0)
            {
                MessageBox.Show("No records to restore!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var item in allDeletedItems.AsEnumerable().Reverse())
            {
                try
                {
                    var row = (dynamic)item;

                    int originalID = row.ID;
                    string inputText = row.S;
                    int shiftValue = row.N;
                    DateTime time = row.T;

                    int uniqueID = GetHistoryUniqueID(originalID);

                    // call the class method
                    RecycleBin bin = new RecycleBin();
                    bin.Restore(uniqueID, inputText, shiftValue.ToString(), time);
                    bin.Delete(originalID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error restoring ID {item.ToString()}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public static void LoadAllDataFromDB(DataGridView binGridView)
        {
            RecycleBin bin = new RecycleBin();
            bin.Display(binGridView);
        }

        public static int CountRecords()
        {
            RecycleBin bin = new RecycleBin();
            return bin.CountRecord();
        }

        public static void AddToRecycleBin(DataGridView dataGridView, DataGridView BinGridView)
        {
            string textBoxS = dataGridView.SelectedRows[0].Cells["StringS"].Value?.ToString();
            string textBoxN = dataGridView.SelectedRows[0].Cells["NumberN"].Value?.ToString();
            string encodedTimeStr = dataGridView.SelectedRows[0].Cells["Time"].Value?.ToString();

            if (string.IsNullOrEmpty(textBoxS) || string.IsNullOrEmpty(textBoxN) || string.IsNullOrEmpty(encodedTimeStr))
            {
                MessageBox.Show("Invalid data! Some required fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime encodedTime = DateTime.Parse(encodedTimeStr);
            int originalID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ID"].Value);

            // call the method
            RecycleBin bin = new RecycleBin();
            bin.AddToBin(originalID, textBoxS, textBoxN, encodedTime);
            bin.Display(BinGridView);
        }

        public static void CheckAndUpdateRecycleBinButtons(DataGridView BinGridView, List<Button> buttons)
        {
            bool hasSelection = BinGridView.SelectedRows.Count > 0;

            foreach (var button in buttons)
            {
                button.Visible = hasSelection;

                if (!hasSelection)
                {
                    button.Location = new Point(-1000, -1000);
                }
            }

            if (hasSelection)
            {
                buttons[0].Location = new Point(10, 310); // RecoveryBTN
                buttons[1].Location = new Point(10, 350); // BinDeleteBTN
            }
        }

        public static void ClearTextboxes(List<TextBox> textBoxes)
        {
            if (textBoxes == null || textBoxes.Count == 0)
                throw new ArgumentException("Error: The list must contain at least one textbox.");

            foreach (var textBox in textBoxes)
            {
                textBox.DataBindings.Clear();
                textBox.Clear();
            }
        }

        public static void ClearGroupTitle(GroupBox groupBox)
        {
            groupBox.Text = "Details (ID: ? )";

        }

        public static void UpdateGroupTitle(GroupBox groupBox, DataGridView binGridView)
        {
            if (binGridView.SelectedRows.Count > 0)
            {
                int originalID = Convert.ToInt32(binGridView.SelectedRows[0].Cells["ID"].Value);
                groupBox.Text = $"Details (ID: {originalID} )";
            }
            else
            {
                ClearGroupTitle(groupBox);
            }
        }

        public static void AddBinding(List<TextBox> textBoxes, DataGridView binGridView)
        {
            if (textBoxes == null || textBoxes.Count == 0)
                throw new ArgumentException("Error: The list must contain at least one textbox.");

            // S and N binding
            textBoxes[0].Text = binGridView.SelectedRows[0].Cells["StringS"].Value?.ToString();
            textBoxes[1].Text = binGridView.SelectedRows[0].Cells["NumberN"].Value?.ToString();

            // Time Binding
            textBoxes[2].Text = binGridView.SelectedRows[0].Cells["Time"].Value?.ToString().Split(' ')[1]; // Time
            textBoxes[3].Text = binGridView.SelectedRows[0].Cells["DeletedTime"].Value?.ToString().Split(' ')[1]; // DeletedTime
            textBoxes[4].Text = binGridView.SelectedRows[0].Cells["Time"].Value?.ToString().Split(' ')[0]; // Date
            textBoxes[5].Text = binGridView.SelectedRows[0].Cells["DeletedTime"].Value?.ToString().Split(' ')[0]; // DDate
        }

        private static List<object> GetAllBinData()
        {
            RecycleBin bin = new RecycleBin();
            return bin.GetAllData();
        }

        public static void FilterData(String filterColumn, String searchText, DataGridView BinGridView)
        {
            var originalData = GetAllBinData();
            if (originalData.Count == 0) return;

            // If search box is empty, load all data from DB and clear the label
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadAllDataFromDB(BinGridView);
                //UpdateSearchLabel(SearchWrnLbl, 0, searchText);
                return;
            }

            BinGridView.Rows.Clear();

            // Create a list to store the filtered results
            List<dynamic> filteredData = new List<dynamic>();

            foreach (var item in originalData)
            {
                var row = (dynamic)item;
                bool match = false;

                if (filterColumn == "ID" && row.ID.ToString().Contains(searchText))
                {
                    match = true;
                }
                else if (filterColumn == "S" && row.S.Contains(searchText))
                {
                    match = true;
                }
                else if (filterColumn == "N" && row.N.ToString().Contains(searchText))
                {
                    match = true;
                }

                if (match)
                {
                    filteredData.Add(row);
                }
            }

            // Add filtered data to DataGridView
            foreach (var row in filteredData)
            {
                BinGridView.Rows.Add(row.ID, row.S, row.N, row.T, row.DT);
            }
        }

        public static void UpdateSearchLabel(Label SearchWrnLbl, int recordCount, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                SearchWrnLbl.Text = " "; 
            }
            else if (recordCount == 0)
            {
                SearchWrnLbl.ForeColor = System.Drawing.Color.Red;
                SearchWrnLbl.Text = "No records found";
            }
            else
            {
                SearchWrnLbl.ForeColor = System.Drawing.Color.Green;
                SearchWrnLbl.Text = $"Found {recordCount} records";
            }
        }


        public static void DeleteFromRecycleBin(DataGridView BinGridView)
        {
            try
            {
                int id = Convert.ToInt32(BinGridView.SelectedRows[0].Cells["ID"].Value);

                //call the method
                RecycleBin bin = new RecycleBin();
                bin.Delete(id);
                bin.Display(BinGridView);

                MessageBox.Show($"Successfully deleted ID {id}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static int GetHistoryUniqueID(int Id)
        {
            StringProcessing history = new StringProcessing();
            return history.GetUniqueID(Id);
        }

        public static void RestoreFromRecycleBin(DataGridView BinGridView)
        {
            try
            {
                string inputText = BinGridView.SelectedRows[0].Cells["StringS"].Value?.ToString();
                string shiftValue = BinGridView.SelectedRows[0].Cells["NumberN"].Value?.ToString();
                DateTime time = Convert.ToDateTime(BinGridView.SelectedRows[0].Cells["Time"].Value);

                int originalID = Convert.ToInt32(BinGridView.SelectedRows[0].Cells["ID"].Value);
                int nextID = GetHistoryUniqueID(originalID);

                // call the class method
                RecycleBin bin = new RecycleBin();
                bin.Restore(nextID, inputText, shiftValue, time);
                bin.Delete(originalID);
                bin.Display(BinGridView);

                MessageBox.Show($"Successfully restored ID {originalID}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ClearRecycleBin(DataGridView BinGridView)
        {
            if (CountRecords() == 0)
            {
                MessageBox.Show("Recycle Bin is already empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RecycleBin bin = new RecycleBin();
            bin.ClearAll();
            bin.Display(BinGridView);
            MessageBox.Show("Recycle Bin cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void RestoreAllFromRecycleBin(DataGridView BinGridView)
        {
            var bin = new RecycleBin();
            bin.RestoreAll();
            bin.Display(BinGridView);
            MessageBox.Show("All records have been successfully restored!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
