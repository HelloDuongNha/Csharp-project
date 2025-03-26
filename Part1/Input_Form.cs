using System.Drawing;
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
            uppercaseBTN.Location = new Point(-1000, -1000);
            //DeleteBTN.Location = new Point(220, 20);


            StringService.InitializeToolTips(encodeBTN, IncreaseBTN, DecreaseBTN, DeleteBTN, ResetBTN);
            StringService.SetupDataGridView(textBoxS, textBoxN, dataGridView);
            StringService.LoadAllDataFromDB(dataGridView);
            StringService.CountRecords(toolStripStatusLabel1);

            RecycleBinService.SetupDataGridView(textBoxS, textBoxN, BinGridView);
            RecycleBinService.LoadAllDataFromDB(BinGridView);
            //StringService.addBinding(textBoxS, textBoxN, dataGridView);
        }

        private void textBoxS_TextChanged(object sender, EventArgs e)
        {
            StringService.UpdateButtonState(textBoxN, IncreaseBTN, DecreaseBTN);
            StringService.ValidateInput(textBoxS.Text, wrnLb1);
            StringService.CountCharacters(textBoxS.Text, CountLbl);
            StringService.CheckAndUpdateUppercaseButton(textBoxS, uppercaseBTN);
        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {
            StringService.UpdateButtonState(textBoxN, IncreaseBTN, DecreaseBTN);
            StringService.UpdateTrackBarValue(textBoxN, trackBar1);
            StringService.ValidateNumberInput(textBoxN, wrnLbl2);
            StringService.AutomaticCheckRadioButton(textBoxN, radioButton0, radioButton10, radioButton25, radioButtonOther);

        }

        private void DecreaseBTN_Click(object sender, EventArgs e)
        {
            StringService.DecreaseNumber(textBoxN, wrnLbl2, radioButton0, radioButton10, radioButton25, radioButtonOther, IncreaseBTN, DecreaseBTN);
        }

        private void IncreaseBTN_Click(object sender, EventArgs e)
        {
            StringService.IncreaseNumber(textBoxN, wrnLbl2, radioButton0, radioButton10, radioButton25, radioButtonOther, IncreaseBTN, DecreaseBTN);
        }

        private void encodeBTN_Click(object sender, EventArgs e)
        {
            StringService.EncodingString(encodeBTN, IncreaseBTN, DecreaseBTN, textBoxS, textBoxN, dataGridView, toolStripStatusLabel1);
            //addBinding();
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
            RecycleBinService.AddToRecycleBin(dataGridView, BinGridView);
            StringService.DeleteDataByID(dataGridView, textBoxS, textBoxN, toolStripStatusLabel1);

            //RecycleBinService.AddToRecycleBin(dataGridView, textBoxS, textBoxN);


            RecycleBinService.SetupDataGridView(textBoxS, textBoxN, BinGridView);
            RecycleBinService.LoadAllDataFromDB(BinGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                StringService.addBinding(textBoxS, textBoxN, dataGridView);
                StringService.CheckAndUpdateDeleteButton(dataGridView, DeleteBTN);
            }

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            StringService.FilterData(textBoxS, textBoxN, comboBox1, Search, dataGridView, searchWrnLbl);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            StringService.ResetAllRecords(dataGridView, textBoxS, textBoxN, toolStripStatusLabel1);
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
                RecycleBinService.addBinding(BinS_Textbox, BinN_Textbox, CreatedTimeTB, DeletedTimeTB, CreatedDateTB, DeletedDateTB, BinGridView);
            }
        }
    }
}