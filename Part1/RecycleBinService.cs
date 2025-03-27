using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Part1
{
    public class RecycleBinService
    {
        public static void SetupDataGridView(TextBox textBoxS, TextBox textBoxN, DataGridView BinGridView)
        {
            BinGridView.Columns.Clear();
            BinGridView.RowHeadersWidth = 30;
            BinGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            BinGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BinGridView.AllowUserToAddRows = false;

            // Căn giữa toàn bộ header
            BinGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cột ID
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "ID";
            idColumn.Width = 25;
            idColumn.ReadOnly = true;
            idColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            idColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa cell
            BinGridView.Columns.Add(idColumn);

            // Cột S (Không căn giữa)
            DataGridViewTextBoxColumn inputSColumn = new DataGridViewTextBoxColumn();
            inputSColumn.Name = "StringS";
            inputSColumn.HeaderText = "S";
            inputSColumn.MinimumWidth = 100;
            inputSColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            inputSColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            inputSColumn.Resizable = DataGridViewTriState.False;
            // Không thiết lập Alignment để giữ nguyên mặc định (căn trái)
            BinGridView.Columns.Add(inputSColumn);

            // Cột N
            DataGridViewTextBoxColumn inputNColumn = new DataGridViewTextBoxColumn();
            inputNColumn.Name = "NumberN";
            inputNColumn.HeaderText = "N";
            inputNColumn.Width = 25;
            inputNColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa cell
            BinGridView.Columns.Add(inputNColumn);

            // Cột Time
            DataGridViewTextBoxColumn createdAtColumn = new DataGridViewTextBoxColumn();
            createdAtColumn.Name = "Time";
            createdAtColumn.HeaderText = "Created at";
            createdAtColumn.Width = 130;
            createdAtColumn.ReadOnly = true;
            createdAtColumn.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"; // Định dạng ngày giờ
            createdAtColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa cell
            createdAtColumn.DefaultCellStyle.Font = new Font("Arial", 8); // Font nhỏ hơn cho cột Time
            BinGridView.Columns.Add(createdAtColumn);

            // Cột DTime
            DataGridViewTextBoxColumn deletedAtColumn = new DataGridViewTextBoxColumn();
            deletedAtColumn.Name = "DeletedTime";
            deletedAtColumn.HeaderText = "Deleted At";
            deletedAtColumn.Width = 130;
            deletedAtColumn.ReadOnly = true;
            deletedAtColumn.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"; // Định dạng ngày giờ
            deletedAtColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa cell
            deletedAtColumn.DefaultCellStyle.Font = new Font("Arial", 8); // Font nhỏ hơn cho cột Time
            BinGridView.Columns.Add(deletedAtColumn);

            // Tùy chỉnh giao diện header
            BinGridView.EnableHeadersVisualStyles = false;
            BinGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            BinGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            BinGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            // Đặt font mặc định cho toàn bộ DataGridView (cỡ 10)
            BinGridView.DefaultCellStyle.Font = new Font("Arial", 10);
        }

        public static void LoadAllDataFromDB(DataGridView binGridView)
        {
            RecycleBinRepository.Load_Data(binGridView);
            binGridView.ClearSelection();
        }

        public static int CountRecords()
        {
            return RecycleBinRepository.CountRecord();
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
            int nextID = RecycleBinRepository.GenerateUniqueID(originalID);


            RecycleBinRepository.Add_Data(nextID, textBoxS, textBoxN, encodedTime, BinGridView);
        }

        public static void CheckAndUpdateRecycleBinButtons(DataGridView BinGridView, Button RecoveryBTN, Button BinDeleteBTN)
        {
            bool hasSelection = BinGridView.SelectedRows.Count > 0;

            RecoveryBTN.Visible = hasSelection;
            BinDeleteBTN.Visible = hasSelection;

            if (!hasSelection)
            {
                RecoveryBTN.Location = new Point(-1000, -1000);
                BinDeleteBTN.Location = new Point(-1000, -1000);
            }
            else
            {
                RecoveryBTN.Location = new Point(10, 310);
                BinDeleteBTN.Location = new Point(10, 350);
            }
        }

        public static void ClearTextBoxes(TextBox textBoxS, TextBox textBoxN, TextBox time, TextBox date, TextBox Dtime, TextBox Ddate, GroupBox groupBox5)
        {
            textBoxS.Clear();
            textBoxN.Clear();
            time.Clear();
            date.Clear();
            Dtime.Clear();
            Ddate.Clear();
            groupBox5.Text = "Details (ID: ? )";

        }

        public static void addBinding(TextBox textBoxS, TextBox textBoxN, TextBox Time, TextBox DTime, TextBox Date, TextBox DDate, DataGridView dataGridView, GroupBox groupBox5)
        {
            textBoxS.DataBindings.Clear();
            textBoxN.DataBindings.Clear();
            Time.DataBindings.Clear();
            DTime.DataBindings.Clear();

            if (dataGridView.SelectedRows.Count > 0)
            {
                int originalID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ID"].Value);

                textBoxS.Text = dataGridView.SelectedRows[0].Cells["StringS"].Value?.ToString();
                textBoxN.Text = dataGridView.SelectedRows[0].Cells["NumberN"].Value?.ToString();
                Time.Text = dataGridView.SelectedRows[0].Cells["Time"].Value?.ToString().Split(' ')[1];
                DTime.Text = dataGridView.SelectedRows[0].Cells["DeletedTime"].Value?.ToString().Split(' ')[1];
                Date.Text = dataGridView.SelectedRows[0].Cells["Time"].Value?.ToString().Split(' ')[0];
                DDate.Text = dataGridView.SelectedRows[0].Cells["DeletedTime"].Value?.ToString().Split(' ')[0];

                // Cập nhật tên GroupBox theo ID
                groupBox5.Text = $"Details (ID: {originalID} )";
            }
            else
            {
                // Nếu không có hàng nào được chọn, đặt lại về mặc định
                textBoxS.Clear();
                textBoxN.Clear();
                Time.Clear();
                DTime.Clear();
                Date.Clear();
                DDate.Clear();

                groupBox5.Text = "Details ID: ?";
            }
        }

        public static void FilterData(ComboBox comboBox1, TextBox textBoxSearch, DataGridView BinGridView, Label SearchWrnLbl)
        {
            var originalData = RecycleBinRepository.GetAllData();
            if (originalData.Count == 0) return;

            string filterColumn = comboBox1.SelectedItem?.ToString() ?? "S";
            string searchText = textBoxSearch.Text.Trim().ToUpper();

            // If search box is empty, load all data from DB and clear the label
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadAllDataFromDB(BinGridView);
                UpdateSearchLabel(SearchWrnLbl, 0, searchText);
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

            // Update the search label with the number of records found
            UpdateSearchLabel(SearchWrnLbl, filteredData.Count, searchText);
        }

        private static void UpdateSearchLabel(Label SearchWrnLbl, int recordCount, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                SearchWrnLbl.Text = " "; // Clear the message when the search box is empty
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

        public static void DeleteFromRecycleBin(DataGridView BinGridView, TextBox BinS_Textbox, TextBox BinN_Textbox, TextBox time, TextBox date, TextBox Dtime, TextBox Ddate, GroupBox groupBox5, Button RcvBTN, Button DltBTN)
        {
            try
            {
                int id = Convert.ToInt32(BinGridView.SelectedRows[0].Cells["ID"].Value);
                RecycleBinRepository.Delete_Data(id);
                RecycleBinRepository.Load_Data(BinGridView);
                BinGridView.ClearSelection();
                //CountRecords(toolStripStatusLabel1);
                ClearTextBoxes(BinS_Textbox, BinN_Textbox, time, date, Dtime, Ddate, groupBox5);
                CheckAndUpdateRecycleBinButtons(BinGridView, RcvBTN, DltBTN);
                MessageBox.Show($"Successfully deleted ID {id}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void RestoreFromRecycleBin(int originalID, TextBox textBoxS, TextBox textBoxN, DataGridView dataGridView, DataGridView BinGridView)
        {
            try
            {

                //int originalID = Convert.ToInt32(BinGridView.SelectedRows[0].Cells["ID"].Value);
                String inputText = BinGridView.SelectedRows[0].Cells["StringS"].Value?.ToString();
                String shiftValue = BinGridView.SelectedRows[0].Cells["NumberN"].Value?.ToString();
                DateTime time = Convert.ToDateTime(BinGridView.SelectedRows[0].Cells["Time"].Value);
                int nextID = StringRepository.GenerateUniqueID(originalID);

                // Create an instance of the string processing class
                StringProcessing processor = new StringProcessing(nextID, inputText, shiftValue, time);
                processor.Encode();
                StringRepository.Add_Data(nextID, inputText, shiftValue, dataGridView, time);

                RecycleBinRepository.Delete_Data(originalID);
                RecycleBinRepository.Load_Data(BinGridView);
                //CountRecords(toolStripStatusLabel1);
                //ClearTextBoxes(textBoxS, textBoxN);
                MessageBox.Show($"Successfully restore ID {originalID}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            RecycleBinRepository.TruncateTable();
            RecycleBinRepository.Load_Data(BinGridView);
            BinGridView.ClearSelection();
            MessageBox.Show("Recycle Bin cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private static void MoveAllOutOffRecycleBin(DataGridView dataGridView, DataGridView BinGridView)
        {
            if (BinGridView.Rows.Count == 0)
            {
                MessageBox.Show("No records to restore!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (DataGridViewRow row in BinGridView.Rows)
            {
                if (row.IsNewRow) continue; // Bỏ qua dòng trống

                try
                {
                    int originalID = Convert.ToInt32(row.Cells["ID"].Value);
                    string inputText = row.Cells["StringS"].Value?.ToString();
                    string shiftValue = row.Cells["NumberN"].Value?.ToString();
                    DateTime time = Convert.ToDateTime(row.Cells["Time"].Value);
                    int nextID = StringRepository.GenerateUniqueID(originalID);

                    // Xử lý mã hóa chuỗi trước khi thêm lại vào bảng chính
                    StringProcessing processor = new StringProcessing(nextID, inputText, shiftValue, time);
                    processor.Encode();
                    StringRepository.Add_Data(nextID, inputText, shiftValue, dataGridView, time);

                    // Xóa dữ liệu đã khôi phục khỏi RecycleBin
                    RecycleBinRepository.Delete_Data(originalID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error restoring ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void RestoreAllFromRecycleBin(DataGridView dataGridView, DataGridView BinGridView)
        {
            MoveAllOutOffRecycleBin(dataGridView, BinGridView);
            // Load lại dữ liệu sau khi khôi phục
            StringRepository.Load_Data(dataGridView);
            RecycleBinRepository.Load_Data(BinGridView);
            dataGridView.ClearSelection();
            BinGridView.ClearSelection();
            MessageBox.Show("All records have been successfully restored!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
