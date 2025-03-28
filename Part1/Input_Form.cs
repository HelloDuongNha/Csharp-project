﻿using System.Drawing;
using System;
using System.Windows.Forms;
using Part1.classes;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Part1
{
    public partial class Input_Form : Form
    {
        public Input_Form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.comboBox1.SelectedIndex = 1;
            this.comboBox2.SelectedIndex = 1;
            uppercaseBTN.Location = new Point(-1000, -1000);
            DeleteBTN.Location = new Point(-1000, -1000);
            RcvBTN.Location = new Point(-1000, -1000);
            DltBTN.Location = new Point(-1000, -1000);



            StringService.InitializeToolTips(encodeBTN, IncreaseBTN, DecreaseBTN, DeleteBTN, ResetBTN);
            StringService.SetupDataGridView(textBoxS, textBoxN, dataGridView);
            StringService.LoadAllDataFromDB(dataGridView);
            StringService.CountRecords(toolStripStatusLabel1);

            RecycleBinService.SetupDataGridView(textBoxS, textBoxN, BinGridView);
            RecycleBinService.LoadAllDataFromDB(BinGridView);
            dataGridView.ClearSelection();
            BinGridView.ClearSelection();

        }

        private bool isBinding = false;
        private bool isBinBinding = false;
        private bool IsConfirmed(int id, string action)
        {
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to {action} ID {id}?",
                $"Confirm {action}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            return confirm == DialogResult.Yes;
        }

        private bool IsConfirmedForAll(string action)
        {
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to {action} ALL records?",
                $"Confirm {action} All",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            return confirm == DialogResult.Yes;
        }

        private void textBoxS_TextChanged(object sender, EventArgs e)
        {
            StringService.UpdateButtonState(textBoxN, IncreaseBTN, DecreaseBTN);
            StringService.ValidateInput(textBoxS.Text, wrnLb1);
            StringService.CountCharacters(textBoxS.Text, CountLbl);
            StringService.CheckAndUpdateUppercaseButton(textBoxS, uppercaseBTN);

            if (!isBinding) // Chỉ clear selection nếu người dùng tự sửa
            {
                StringService.ClearSelectionAndHideDeleteButton(dataGridView, DeleteBTN);
            }
        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {
            StringService.UpdateButtonState(textBoxN, IncreaseBTN, DecreaseBTN);
            StringService.UpdateTrackBarValue(textBoxN, trackBar1);
            StringService.ValidateNumberInput(textBoxN, wrnLbl2);

            if (int.TryParse(textBoxN.Text, out int value))
            {
                // Ensure that the radio button is automatically selected only when the user is typing in the textbox
                if (textBoxN.Focused)
                {
                    StringService.UpdateRadioButton(value, radioButton0, radioButton10, radioButton25, radioButtonOther);
                }
            }
            else
            {
                radioButtonOther.Checked = true;
            }
            //StringService.AutomaticCheckRadioButton(textBoxN, radioButton0, radioButton10, radioButton25, radioButtonOther);

        }

        private void DecreaseBTN_Click(object sender, EventArgs e)
        {
            StringService.DecreaseNumber(textBoxN);
            int value = StringService.TryParseInt(textBoxN);
            StringService.UpdateRadioButton(value, radioButton0, radioButton10, radioButton25, radioButtonOther);
            StringService.ValidateNumberInput(textBoxN, wrnLbl2);
            StringService.UpdateButtonState(textBoxN, IncreaseBTN, DecreaseBTN);
        }

        private void IncreaseBTN_Click(object sender, EventArgs e)
        {
            StringService.IncreaseNumber(textBoxN);
            int value = StringService.TryParseInt(textBoxN);
            StringService.UpdateRadioButton(value, radioButton0, radioButton10, radioButton25, radioButtonOther);
            StringService.ValidateNumberInput(textBoxN, wrnLbl2);
            StringService.UpdateButtonState(textBoxN, IncreaseBTN, DecreaseBTN);
        }

        private void encodeBTN_Click(object sender, EventArgs e)
        {
            StringService.EncodingString(encodeBTN, IncreaseBTN, DecreaseBTN, textBoxS, textBoxN);
            StringService.LoadAllDataFromDB(dataGridView);
            StringService.CountRecords(toolStripStatusLabel1);
            StringService.ClearTextBoxes(textBoxS, textBoxN);
        }

        private void UppercaseBTN_Click(object sender, EventArgs e)
        {
            StringService.UpperCaseTextbox(textBoxS);
            StringService.CheckAndUpdateUppercaseButton(textBoxS, uppercaseBTN);
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //}

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row before deleting!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thực hiện tiếp nếu không có hàng nào được chọn
            }
            int originalID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ID"].Value);

            // Kiểm tra xác nhận từ người dùng
            if (!IsConfirmed(originalID, "delete")) return;

            // Thêm vào RecycleBin trước khi xóa
            RecycleBinService.AddToRecycleBin(dataGridView, BinGridView);
            StringService.DeleteDataByID(dataGridView, DeleteBTN);
            StringService.CountRecords(toolStripStatusLabel1);
            StringService.ClearTextBoxes(textBoxS, textBoxN);

            //RecycleBinService.SetupDataGridView(textBoxS, textBoxN, BinGridView);
            RecycleBinService.LoadAllDataFromDB(BinGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isBinding = true; // Đánh dấu rằng binding đang diễn ra
                StringService.addBinding(textBoxS, textBoxN, dataGridView);
                StringService.CheckAndUpdateDeleteButton(dataGridView, DeleteBTN);
                isBinding = false; // Kết thúc binding
            }


        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            StringService.FilterData(comboBox1, Search, dataGridView, searchWrnLbl);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (!IsConfirmedForAll("delete")) return;
            StringService.ResetAllRecords(dataGridView, BinGridView);
            StringService.CountRecords(toolStripStatusLabel1);
            StringService.ClearTextBoxes(textBoxS, textBoxN);


        }

        private void radioButton10_click(object sender, EventArgs e)
        {
            StringService.UpdateTextBoxFromRadio(sender, e, textBoxN);
        }

        private void radioButton25_Click(object sender, EventArgs e)
        {
            StringService.UpdateTextBoxFromRadio(sender, e, textBoxN);
            StringService.UpdateButtonState(textBoxN, IncreaseBTN, DecreaseBTN);
        }

        private void radioButton0_Click(object sender, EventArgs e)
        {
            StringService.UpdateTextBoxFromRadio(sender, e, textBoxN);
        }

        private void clearInput_Click(object sender, EventArgs e)
        {
            StringService.ClearTextBoxes(textBoxS, textBoxN);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBoxN.Text = trackBar1.Value.ToString(); 
            StringService.UpdateRadioButton(trackBar1.Value, radioButton0, radioButton10, radioButton25, radioButtonOther);
        }

        private void BinGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isBinBinding = true; // Đánh dấu rằng binding đang diễn ra
                RecycleBinService.ClearTextboxSN(BinS_Textbox, BinN_Textbox);
                RecycleBinService.ClearTextboxTime(CreatedTimeTB, CreatedDateTB, DeletedTimeTB, DeletedDateTB);
                if (BinGridView.SelectedRows.Count > 0)
                {
                    RecycleBinService.addBindingSN(BinS_Textbox, BinN_Textbox, BinGridView);
                    RecycleBinService.addBindingTime(CreatedTimeTB, CreatedDateTB, DeletedTimeTB, DeletedDateTB, BinGridView);
                    RecycleBinService.UpdateGroupTitle(groupBox5, BinGridView);
                } 
                else
                {
                    RecycleBinService.ClearTextboxSN(BinS_Textbox, BinN_Textbox);
                    RecycleBinService.ClearTextboxTime(CreatedTimeTB, CreatedDateTB, DeletedTimeTB, DeletedDateTB);
                    RecycleBinService.ClearGroupTitle(groupBox5);
                }
                    RecycleBinService.CheckAndUpdateRecycleBinButtons(BinGridView, RcvBTN, DltBTN);
                isBinBinding = false; // Kết thúc binding
            }
        }

        private void RcvBTN_Click(object sender, EventArgs e)
        {
            int originalID = Convert.ToInt32(BinGridView.SelectedRows[0].Cells["ID"].Value);

            // Kiểm tra xác nhận từ người dùng
            if (!IsConfirmed(originalID, "restore")) return;

            RecycleBinService.RestoreFromRecycleBin(dataGridView, BinGridView);
            RecycleBinService.ClearTextboxSN(BinS_Textbox, BinN_Textbox);
            RecycleBinService.ClearTextboxTime(CreatedTimeTB, CreatedDateTB, DeletedTimeTB, DeletedDateTB);
            RecycleBinService.ClearGroupTitle(groupBox5);
        }

        private void BinDltBTN_Click(object sender, EventArgs e)
        {
            int originalID = Convert.ToInt32(BinGridView.SelectedRows[0].Cells["ID"].Value);

            // Kiểm tra xác nhận từ người dùng
            if (!IsConfirmed(originalID, "delete")) return;

            // Thêm vào RecycleBin trước khi xóa
            //RecycleBinService.AddToRecycleBin(dataGridView, BinGridView);
            RecycleBinService.DeleteFromRecycleBin(BinGridView);
            //RecycleBinService.LoadAllDataFromDB(BinGridView);
            RecycleBinService.ClearTextboxSN(BinS_Textbox, BinN_Textbox);
            RecycleBinService.ClearTextboxTime(CreatedTimeTB, CreatedDateTB, DeletedTimeTB, DeletedDateTB);
            RecycleBinService.ClearGroupTitle(groupBox5);
            RecycleBinService.CheckAndUpdateRecycleBinButtons(BinGridView, RcvBTN, DltBTN);
        }

        private void DeletedAllBTN_Click(object sender, EventArgs e)
        {
            if (!IsConfirmedForAll("delete")) return;
            RecycleBinService.ClearRecycleBin(BinGridView);
            RecycleBinService.ClearTextboxSN(BinS_Textbox, BinN_Textbox);
            RecycleBinService.ClearTextboxTime(CreatedTimeTB, CreatedDateTB, DeletedTimeTB, DeletedDateTB);
            RecycleBinService.ClearGroupTitle(groupBox5);
        }

        private void RecoveryAllBTN_Click(object sender, EventArgs e)
        {
            if (!IsConfirmedForAll("restore")) return;
            RecycleBinService.RestoreAllFromRecycleBin(dataGridView, BinGridView);
            RecycleBinService.ClearTextboxSN(BinS_Textbox, BinN_Textbox);
            RecycleBinService.ClearTextboxTime(CreatedTimeTB, CreatedDateTB, DeletedTimeTB, DeletedDateTB);
            RecycleBinService.ClearGroupTitle(groupBox5);
        }

        private void BinSearchingTB_TextChanged(object sender, EventArgs e)
        {
            RecycleBinService.FilterData(comboBox2, BinSearchingTB, BinGridView, searchWrnLbl2);
        }
    }
}