using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Crmf;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace Part1
{
    public static class StringService
    {
        public static void SetupDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.RowHeadersWidth = 30;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.AllowUserToAddRows = false;

            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "ID";
            idColumn.Width = 25;
            idColumn.ReadOnly = true;
            idColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            idColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns.Add(idColumn);

            DataGridViewTextBoxColumn inputSColumn = new DataGridViewTextBoxColumn();
            inputSColumn.Name = "StringS";
            inputSColumn.HeaderText = "S";
            inputSColumn.MinimumWidth = 100;
            inputSColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            inputSColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            inputSColumn.Resizable = DataGridViewTriState.False;
            dataGridView.Columns.Add(inputSColumn);

            DataGridViewTextBoxColumn inputNColumn = new DataGridViewTextBoxColumn();
            inputNColumn.Name = "NumberN";
            inputNColumn.HeaderText = "N";
            inputNColumn.Width = 25;
            inputNColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 
            dataGridView.Columns.Add(inputNColumn);

            DataGridViewTextBoxColumn createdAtColumn = new DataGridViewTextBoxColumn();
            createdAtColumn.Name = "Time";
            createdAtColumn.HeaderText = "Created at";
            createdAtColumn.Width = 130;
            createdAtColumn.ReadOnly = true;
            createdAtColumn.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            createdAtColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            createdAtColumn.DefaultCellStyle.Font = new Font("Arial", 8); 
            dataGridView.Columns.Add(createdAtColumn);

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            dataGridView.DefaultCellStyle.Font = new Font("Arial", 10);
        }

        public static String Encode(string s, int shift)
        {
            s = s.Trim();
            string result = "";
            foreach (char c in s)
            {
                char shiftedChar = ShiftChar(c, shift);
                result += shiftedChar;
            }
            return result;
        }

        private static char ShiftChar(char c, int shift)
        {
            int newChar = c + shift;
            if (newChar > 'Z') newChar -= 26;
            if (newChar < 'A') newChar += 26;
            return (char)newChar;
        }

        public static string Sort(string s)
        {
            //s = s.Trim();
            //s = s.Replace(" ", "");
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            return new string(charArray);
        }

        public static int[] InputCode(string s)
        {
            //s = s.Trim();
            //s = s.Replace(" ", "");
            int[] asciiValues = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                asciiValues[i] = (int)s[i];
            }
            return asciiValues;
        }

        public static int[] OutputCode(string encodedString)
        {
            int[] asciiValues = new int[encodedString.Length];
            for (int i = 0; i < encodedString.Length; i++)
            {
                asciiValues[i] = (int)encodedString[i];
            }
            return asciiValues;
        }

        public static void CountCharacters(string input, Label labelCharCount)
        {
            labelCharCount.Text = $"Length: {input.Trim().Length}/40";
        }

        public static void CountRecords(ToolStripLabel toolStripStatusLabel1)
        {
            StringProcessing history = new StringProcessing();
            toolStripStatusLabel1.Text = $"Total record: {history.CountRecord()}";
        }

        private static int GetNextIdHistory()
        {
            StringProcessing history = new StringProcessing();
            return history.GetNextID(); 
        }

        private static int GetUniqueID(int id)
        {
            StringProcessing history = new StringProcessing();
            return history.GetUniqueID(id);
        }

        public static void ValidateInput(string input, Label statusLabel)
        {
            //input = input.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                statusLabel.ForeColor = System.Drawing.Color.Red;
                statusLabel.Text = "❎ Cannot be empty.";
                return;
            }

            else if (input.Length > 40)
            {
                statusLabel.ForeColor = System.Drawing.Color.Red;
                statusLabel.Text = "❎ Cannot exceed 40 characters.";
                return;
            }

            else if (input.Any(char.IsWhiteSpace))
            {
                statusLabel.ForeColor = System.Drawing.Color.Red;
                statusLabel.Text = "❎ No spaces or whitespace characters allowed.";
                return;
            }

            else if (!input.All(char.IsUpper))
            {
                statusLabel.ForeColor = System.Drawing.Color.Red;
                statusLabel.Text = "❎ Only uppercase letters A-Z are allowed.";
                return;
            }

            statusLabel.ForeColor = System.Drawing.Color.Green;
            statusLabel.Text = "✅ Valid.";
        }

        public static void ValidateNumberInput(TextBox textBox, Label statusLabel)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                statusLabel.ForeColor = System.Drawing.Color.Red;
                statusLabel.Text = "❎ Cannot be empty.";
                return;
            }

            if (!int.TryParse(textBox.Text, out int value))
            {
                statusLabel.ForeColor = System.Drawing.Color.Red;
                statusLabel.Text = "❎ Must enter an integer.";
                return;
            }

            if (value < -25 || value > 25)
            {
                statusLabel.ForeColor = System.Drawing.Color.Red;
                statusLabel.Text = "❎ Value must be between -25 and 25.";
                return;
            }

            statusLabel.ForeColor = System.Drawing.Color.Green;
            statusLabel.Text = "✅ Valid.";
        }

        public static int TryParseInt(TextBox textBox)
        {
            if (int.TryParse(textBox.Text, out int value))
            {
                return value;
            }
            return 0;
        }

        public static void IncreaseNumber(TextBox textBoxN)
        {
            int currentValue = TryParseInt(textBoxN);

            if (currentValue < 25)
            {
                textBoxN.Text = (currentValue + 1).ToString(); 
            }
        }

        public static void DecreaseNumber(TextBox textBoxN  )
        {
            int currentValue = TryParseInt(textBoxN);

            if (currentValue >  -25)
            {
                textBoxN.Text = (currentValue - 1).ToString();
            }
        }

        public static void UpdateTextBoxFromRadio(object sender, TextBox textBoxN)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                textBoxN.Text = radioButton.Text;
            }
        }

        public static void UpdateTrackBarValue(TextBox textBoxN, TrackBar trackBar)
        {
            int value;

            if (!int.TryParse(textBoxN.Text, out value) || value < -25 || value > 25)
            {
                value = 0;
            }
            textBoxN.SelectionStart = textBoxN.Text.Length;
            textBoxN.Text = value.ToString();
            trackBar.Value = value;
        }

        public static void UpdateButtonState(TextBox textBox, Button increaseBTN, Button decreaseBTN)
        {
            if (int.TryParse(textBox.Text, out int value))
            {
                increaseBTN.Enabled = (value < 25);
                decreaseBTN.Enabled = (value > -25);
            }
            else
            {
                increaseBTN.Enabled = true;
                decreaseBTN.Enabled = true;
            }
        }

        // update the appropriate radio button
        public static void UpdateRadioButton(int value, List<RadioButton> radioButtons)
        {
            if (radioButtons == null || radioButtons.Count < 4)
                throw new ArgumentException("Error: The radio button list must contain at least 4 buttons.");

            int[] values = { 0, 10, 25 };

            for (int i = 0; i < values.Length; i++)
            {
                if (value == values[i])
                {
                    radioButtons[i].Checked = true;
                    return;
                }
            }

            radioButtons[3].Checked = true;
        }

        private static ToolTip toolTip = new ToolTip();

        public static void InitializeToolTips(List<Button> buttons)
        {
            if (buttons == null || buttons.Count < 5)
                throw new ArgumentException("Error: The button list must contain at least 5 buttons.");

            toolTip.AutoPopDelay = 3000;
            toolTip.InitialDelay = 1000;

            string[] toolTipTexts =
            {
                "Encode the text",
                "Increase the value",   
                "Decrease the value",
                "Delete the selected record",
                "Delete all records"
            };

            for (int i = 0; i < toolTipTexts.Length; i++)
            {
                toolTip.SetToolTip(buttons[i], toolTipTexts[i]);
            }
        }

        public static void EncodingString(TextBox textBoxS, TextBox textBoxN)
        {
            try
            {
                GUI_OutputForm Form2 = new GUI_OutputForm();

                // Get values from textboxes
                int nextID = GetNextIdHistory();
                string inputText = textBoxS.Text;
                string shiftValue = textBoxN.Text;

                // Create an instance of the string processing class
                DateTime time = DateTime.Now;
                StringProcessing processor = new StringProcessing(nextID, inputText, shiftValue, time);
                processor.Encode();
                processor.AddToHistory(nextID, inputText, shiftValue, time);

                // Display the results
                Form2.encodedTXT.Text = processor.Print();
                Form2.InCodeTXT.Text = string.Join(" ", processor.InputCode());
                Form2.OutcodeTXT.Text = string.Join(" ", processor.OutputCode());
                Form2.InSortTXT.Text = processor.Sort();
                Form2.StartPosition = FormStartPosition.CenterScreen;
                toolTip.SetToolTip(Form2.ExitBTN, "Exit the program");
                Form2.ShowDialog();
                ClearTextBoxes(textBoxS, textBoxN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpperCaseTextbox(TextBox textBox)
        {
            textBox.Text = textBox.Text.ToUpper();
        }

        public static void CheckAndUpdateUppercaseButton(TextBox textBoxS, Button uppercaseBTN)
        {
            bool hasLowercase = textBoxS.Text.Any(char.IsLower);

            if (hasLowercase)
            {
                // Show the button to the right location
                uppercaseBTN.Location = new Point(220, 20);
                uppercaseBTN.Visible = true;
                uppercaseBTN.BringToFront();
            }
            else
            {
                // Hide it to nowhere :>
                uppercaseBTN.Location = new Point(-1000, -1000);
                uppercaseBTN.Visible = false;
            }
        }

        public static void CheckAndUpdateDeleteButton(DataGridView dataGridView, Button deleteBTN)
        {
            bool hasSelection = dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count > 0;

            if (hasSelection)
            {
                // show
                deleteBTN.Location = new Point(330, 329);
                deleteBTN.Visible = true;
                deleteBTN.BringToFront();
            }
            else
            {
                // hide
                deleteBTN.Location = new Point(-1000, -1000);
                deleteBTN.Visible = false;
            }
        }

        public static void ClearSelectionAndHideDeleteButton(DataGridView dataGridView, Button deleteBTN)
        {
            dataGridView.ClearSelection(); 

            CheckAndUpdateDeleteButton(dataGridView, deleteBTN);
        }

        public static void ClearTextBoxes(TextBox textBoxS, TextBox textBoxN)
        {
            textBoxS.Clear();
            textBoxN.Text = "0";
        }

        public static void LoadAllDataFromDB(DataGridView dataGridView)
        {
            StringProcessing history = new StringProcessing();
            history.Display(dataGridView);
        }

        public static void addBinding(TextBox textBoxS, TextBox textBoxN, DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                textBoxS.Text = dataGridView.SelectedRows[0].Cells["StringS"].Value?.ToString();
                textBoxN.Text = dataGridView.SelectedRows[0].Cells["NumberN"].Value?.ToString();
            }
        }

        private static List<object> GetAllHistoryData()
        {
            StringProcessing history = new StringProcessing();
            return history.GetAllData();
        }

        public static void FilterData(String filter, String searchTxt, DataGridView dataGridView)
        {
            List<object> originalData = GetAllHistoryData();
            if (originalData.Count == 0) return;

            dataGridView.Rows.Clear();

            // Create a list to store the filtered results
            List<dynamic> filteredData = new List<dynamic>();

            foreach (var item in originalData)
            {
                var row = (dynamic)item;
                bool match = false;

                if (filter == "ID" && row.HistoryID.ToString().Contains(searchTxt))
                {
                    match = true;
                }
                else if (filter == "S" && row.S.Contains(searchTxt))
                {
                    match = true;
                }
                else if (filter == "N" && row.N.ToString().Contains(searchTxt))
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
                dataGridView.Rows.Add(row.HistoryID, row.S, row.N, row.T);
            }
        }

        public static void UpdateSearchLabel(Label SearchWrnLbl, int recordCount, string searchText)
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

        public static void DeleteDataByID(DataGridView dataGridView, Button DeleteBTN)
        {
            int rowIndex = dataGridView.SelectedCells[0].RowIndex;
            object cellValue = dataGridView.Rows[rowIndex].Cells["ID"].Value;

            if (cellValue == null)
            {
                MessageBox.Show("Invalid ID value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(cellValue);
            
            StringProcessing History =  new StringProcessing();
            History.Delete(id);
            History.Display(dataGridView);
            
            dataGridView.ClearSelection();

            MessageBox.Show($"Successfully deleted ID {id}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CheckAndUpdateDeleteButton(dataGridView, DeleteBTN);
        }

        private static void MoveAllToRecycleBin(DataGridView dataGridView)
        {
            // if null
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No records to move!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView.Rows[i];

                string textBoxS = row.Cells["StringS"].Value?.ToString();
                string textBoxN = row.Cells["NumberN"].Value?.ToString();
                string encodedTimeStr = row.Cells["Time"].Value?.ToString();
                object idValue = row.Cells["ID"].Value;

                // add to RecycleBin
                if (!string.IsNullOrEmpty(textBoxS) && !string.IsNullOrEmpty(textBoxN) && DateTime.TryParse(encodedTimeStr, out DateTime encodedTime))
                {
                    int originalID = Convert.ToInt32(idValue);

                    RecycleBin bin = new RecycleBin();
                    bin.AddToBin(originalID, textBoxS, textBoxN, encodedTime);
                }
            }

            // successful
            MessageBox.Show("All records have been moved to the Recycle Bin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public static void ResetAllRecords(DataGridView dataGridView)
        {
            MoveAllToRecycleBin(dataGridView);
            StringProcessing history = new StringProcessing();
            history.Reset();
            history.Display(dataGridView);
        }

    }
}
