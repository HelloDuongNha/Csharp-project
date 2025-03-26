using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Crmf;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Part1.classes
{
    public static class StringService
    {
        public static void SetupDataGridView(TextBox textBoxS, TextBox textBoxN, DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.RowHeadersWidth = 30;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.AllowUserToAddRows = false;

            // Căn giữa toàn bộ header
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cột ID
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "ID";
            idColumn.Width = 25;
            idColumn.ReadOnly = true;
            idColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            idColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa cell
            dataGridView.Columns.Add(idColumn);

            // Cột S (Không căn giữa)
            DataGridViewTextBoxColumn inputSColumn = new DataGridViewTextBoxColumn();
            inputSColumn.Name = "StringS";
            inputSColumn.HeaderText = "S";
            inputSColumn.MinimumWidth = 100;
            inputSColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            inputSColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            inputSColumn.Resizable = DataGridViewTriState.False;
            // Không thiết lập Alignment để giữ nguyên mặc định (căn trái)
            dataGridView.Columns.Add(inputSColumn);

            // Cột N
            DataGridViewTextBoxColumn inputNColumn = new DataGridViewTextBoxColumn();
            inputNColumn.Name = "NumberN";
            inputNColumn.HeaderText = "N";
            inputNColumn.Width = 25;
            inputNColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa cell
            dataGridView.Columns.Add(inputNColumn);

            // Cột Time
            DataGridViewTextBoxColumn createdAtColumn = new DataGridViewTextBoxColumn();
            createdAtColumn.Name = "Time";
            createdAtColumn.HeaderText = "Created at";
            createdAtColumn.Width = 130;
            createdAtColumn.ReadOnly = true;
            createdAtColumn.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"; // Định dạng ngày giờ
            createdAtColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa cell
            createdAtColumn.DefaultCellStyle.Font = new Font("Arial", 8); // Font nhỏ hơn cho cột Time
            dataGridView.Columns.Add(createdAtColumn);

            // Tùy chỉnh giao diện header
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            // Đặt font mặc định cho toàn bộ DataGridView (cỡ 10)
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
            toolStripStatusLabel1.Text = $"Total record: {StringRepository.CountRecord()}";
        }

        public static void ValidateInput(string input, Label statusLabel)
        {
            input = input.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                statusLabel.ForeColor = System.Drawing.Color.Red;
                statusLabel.Text = "❎ Cannot be empty.";
                return;
            }

            if (input.Length > 40)
            {
                statusLabel.ForeColor = System.Drawing.Color.Red;
                statusLabel.Text = "❎ Cannot exceed 40 characters.";
                return;
            }

            string trimmedInput = input.Replace(" ", "");
            if (!Regex.IsMatch(trimmedInput, @"^[A-Z]+$"))
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

        public static void IncreaseNumber(TextBox textBox, Label statusLabel, RadioButton radio0, RadioButton radio10, RadioButton radio25, RadioButton radioOther, Button increaseBTN, Button decreaseBTN)
        {
            if (int.TryParse(textBox.Text, out int value) && value < 25)
            {
                textBox.Text = (value+1).ToString();
            }

            UpdateRadioButton(value, radio0, radio10, radio25, radioOther);
            ValidateNumberInput(textBox, statusLabel);
            UpdateButtonState(textBox, increaseBTN, decreaseBTN); // Cập nhật trạng thái nút
        }

        public static void DecreaseNumber(TextBox textBox, Label statusLabel, RadioButton radio0, RadioButton radio10, RadioButton radio25, RadioButton radioOther, Button increaseBTN, Button decreaseBTN)
        {
            if (int.TryParse(textBox.Text, out int value) && value > -25)
            {
                textBox.Text = (value-1).ToString();
            }

            UpdateRadioButton(value, radio0, radio10, radio25, radioOther);
            ValidateNumberInput(textBox, statusLabel);
            UpdateButtonState(textBox, increaseBTN, decreaseBTN); 
        }

        public static void UpdateTextBoxFromRadio(object sender, EventArgs e, TextBox textBoxN)
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
        public static void UpdateRadioButton(int value, RadioButton radio0, RadioButton radio10, RadioButton radio25, RadioButton radioOther)
        {
            if (value == 0) radio0.Checked = true;
            else if (value == 10) radio10.Checked = true;
            else if (value == 25) radio25.Checked = true;
            else radioOther.Checked = true;
        }

        public static void AutomaticCheckRadioButton(TextBox textBoxN, RadioButton radioButton0, RadioButton radioButton10, RadioButton radioButton25, RadioButton radioButtonOther)
        {
            if (int.TryParse(textBoxN.Text, out int value))
            {
                // Ensure that the radio button is automatically selected only when the user is typing in the textbox
                if (textBoxN.Focused)
                {
                    UpdateRadioButton(value, radioButton0, radioButton10, radioButton25, radioButtonOther);
                }
            }
            else
            {
                radioButtonOther.Checked = true;
            }
        }

        public static ToolTip toolTip = new ToolTip();

        public static void InitializeToolTips(Button encodeBTN, Button IncreaseBTN, Button DecreaseBTN, Button DeleteBTN, Button ClearAllBTN)
        {
            toolTip.AutoPopDelay = 3000;
            toolTip.InitialDelay = 1000;
            toolTip.SetToolTip(encodeBTN, "Encode the text");
            toolTip.SetToolTip(IncreaseBTN, "Increase the value");
            toolTip.SetToolTip(DecreaseBTN, "Decrease the value");
            toolTip.SetToolTip(DeleteBTN, "Delete the selected record");
            toolTip.SetToolTip(ClearAllBTN, "Delete all records");
            //toolTip.SetToolTip(ExitBTN, "Exit the program");
        }

        public static void EncodingString(Button encodeBTN, Button IncreaseBTN, Button DecreaseBTN, TextBox textBoxS, TextBox textBoxN, DataGridView dataGridView, ToolStripLabel toolStripStatusLabel1)
        {
            try
            {
                Output_Form Form2 = new Output_Form();
                //InitializeToolTips(encodeBTN, IncreaseBTN, DecreaseBTN);
                // Get values from textboxes
                int nextID = StringRepository.GetNextID();
                string inputText = textBoxS.Text;
                string shiftValue = textBoxN.Text;

                // Create an instance of the string processing class
                StringProcessing processor = new StringProcessing(nextID, inputText, shiftValue);
                processor.Encode();
                StringRepository.Add_Data(nextID, textBoxS, textBoxN, dataGridView);

                // Display the results
                Form2.encodedTXT.Text = processor.Print();
                Form2.InCodeTXT.Text = string.Join(" ", processor.InputCode());
                Form2.OutcodeTXT.Text = string.Join(" ", processor.OutputCode());
                Form2.InSortTXT.Text = processor.Sort();
                Form2.StartPosition = FormStartPosition.CenterScreen;
                toolTip.SetToolTip(Form2.ExitBTN, "Exit the program");
                Form2.ShowDialog();
                CountRecords(toolStripStatusLabel1);
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
            // Kiểm tra xem DataGridView có focus không và có ít nhất một hàng/ô được chọn không
            bool hasSelection = (dataGridView.Focused || dataGridView.ContainsFocus) &&
                                (dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count > 0);

            if (hasSelection)
            {
                // Hiển thị nút Delete tại vị trí mong muốn
                deleteBTN.Location = new Point(220, 50);
                deleteBTN.Visible = true;
                deleteBTN.BringToFront();
            }
            else
            {
                // Ẩn nút Delete ra ngoài màn hình
                deleteBTN.Location = new Point(-1000, -1000);
                deleteBTN.Visible = false;
            }
        }


        public static void ClearTextBoxes(TextBox textBoxS, TextBox textBoxN)
        {
            textBoxS.Clear();
            textBoxN.Text = "0";
        }

        public static void LoadAllDataFromDB(DataGridView dataGridView)
        {
            StringRepository.Load_Data(dataGridView);
        }

        public static void addBinding(TextBox textBoxS, TextBox textBoxN, DataGridView dataGridView)
        {
            textBoxS.DataBindings.Clear();
            textBoxN.DataBindings.Clear();

            if (dataGridView.SelectedRows.Count > 0)
            {
                textBoxS.Text = dataGridView.SelectedRows[0].Cells["StringS"].Value?.ToString();
                textBoxN.Text = dataGridView.SelectedRows[0].Cells["NumberN"].Value?.ToString();
            }
        }

        public static void FilterData(TextBox textBoxS, TextBox textBoxN, ComboBox comboBox1, TextBox textBoxSearch, DataGridView dataGridView, Label SearchWrnLbl)
        {
            var originalData = StringRepository.GetAllData();
            if (originalData.Count == 0) return;

            string filterColumn = comboBox1.SelectedItem?.ToString() ?? "S";
            string searchText = textBoxSearch.Text.Trim().ToUpper();

            // If search box is empty, load all data from DB and clear the label
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadAllDataFromDB(dataGridView);
                UpdateSearchLabel(SearchWrnLbl, 0, searchText);
                return;
            }

            dataGridView.Rows.Clear();

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
                dataGridView.Rows.Add(row.ID, row.S, row.N, row.T);
            }

            // Update the search label with the number of records found
            UpdateSearchLabel(SearchWrnLbl, filteredData.Count, searchText);
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

        public static void DeleteDataByID(DataGridView dataGridView, TextBox textBoxS, TextBox textBoxN, ToolStripLabel toolStripStatusLabel1)
        {
            int rowIndex = dataGridView.SelectedCells[0].RowIndex;
            object cellValue = dataGridView.Rows[rowIndex].Cells["ID"].Value;

            if (cellValue == null)
            {
                MessageBox.Show("Invalid ID value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(cellValue);

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete ID {id}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes) return;

            StringRepository.Delete_Data(id);
            StringRepository.Load_Data(dataGridView);
            CountRecords(toolStripStatusLabel1);
            ClearTextBoxes(textBoxS, textBoxN);

            MessageBox.Show($"Successfully deleted ID {id}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ResetAllRecords(DataGridView dataGridView, TextBox textBoxS, TextBox textBoxN, ToolStripLabel toolStripStatusLabel1)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete ALL records? This action cannot be undone!",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes) return;

            StringRepository.TruncateTable();
            StringRepository.Load_Data(dataGridView);
            CountRecords(toolStripStatusLabel1);
            ClearTextBoxes(textBoxS, textBoxN);

            MessageBox.Show("All records have been deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
