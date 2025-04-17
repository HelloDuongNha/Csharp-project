using System.Drawing;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using Part1.GUI;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Part1
{
    public partial class GUI_InputForm : Form
    {
        public GUI_InputForm()
        {
            InitializeComponent();

            // set up and hide some buttons
            this.StartPosition = FormStartPosition.CenterScreen;
            this.comboBox1.SelectedIndex = 1;
            this.comboBox2.SelectedIndex = 1;
            uppercaseBTN.Location = new Point(-1000, -1000);
            DeleteBTN.Location = new Point(-1000, -1000);
            RcvBTN.Location = new Point(-1000, -1000);
            DltBTN.Location = new Point(-1000, -1000);
            AdminDeleteUserBTN.Location = new Point(-1000, -1000);

            // set up Homepage
            List<Button> buttons = new List<Button> { encodeBTN, IncreaseBTN, DecreaseBTN, DeleteBTN, ResetBTN };
            StringService.InitializeToolTips(buttons);
            StringService.SetupDataGridView(dataGridView);

            // set up User account info to textboxes in Settings tab
            List<TextBox> textBoxesInput = new List<TextBox>
                {
                    UsernameIn4,
                    EmailIn4,
                    TimeIn4,
                    DateIn4,
                };
            AccountService.BindLoggedInAccountToTextBoxes(textBoxesInput);
            AccountService.UpdateAccIDTitle(groupBox6);

            // set up Recycle Bin
            RecycleBinService.SetupDataGridView(BinGridView);

            // set up Admin
            AccountService.SetupDataGridView(AccGridView);

            // Load Previous Settings
            SettingService.LoadSettings();
            var res = GetCurrentSetting();
            if (res.Mode == "Fullscreen")
            {
                SettingService.ApplyMode(this, Width, Height);
            }
            SettingService.BindSettingToControls(RBdarkmodeON, RBdarkmodeOff, RBWindow, RBFullscreen, Width, Height, Opacity);
            SettingService.LoadResolution(res.Width, res.Height, this);
            SettingService.CenterTabControl(this);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var acc = GetCurrentAccLoginDetail();
            this.tabControl1.Controls.Remove(this.tabPage4);
            if (acc.Role.Trim().ToLower() == "admin")
            {
                this.tabControl1.TabPages.Add(this.tabPage4);
                DeleteAccBtn.Location = new Point(-1000, -1000);
            }
            else
            {
                DeleteAccBtn.Location = new Point(11, 116);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Load Homepage DataGridView
            StringService.LoadAllDataFromDB(dataGridView);
            StringService.CountRecords(toolStripStatusLabel1);

            // Load Recycle Bin DataGridView
            RecycleBinService.LoadAllDataFromDB(BinGridView);
            RecycleBinService.CountRecords(toolStripStatusLabel2);

            // Load Admin DataGridView (only for Admin)
            var acc = GetCurrentAccLoginDetail();
            if (acc.Role.Trim().ToLower() == "admin")
            {
                AccountService.LoadDataToGridView(AccGridView);
                AccountService.CountRecords(toolStripStatusLabel3);
            }
        }

        private Account GetCurrentAccLoginDetail() 
        {
            Account account = new Account();
            return account.GetLoggedInAccountDetails();
        }

        private Setting GetCurrentSetting()
        {
            Setting setting = new Setting();
            return setting.GetCurrentSetting();
        }

        private void ClearBinTextBoxes()
        {
            List<TextBox> textBoxes = new List<TextBox> { BinS_Textbox, BinN_Textbox, CreatedTimeTB, CreatedDateTB, DeletedTimeTB, DeletedDateTB };
            RecycleBinService.ClearTextboxes(textBoxes);
        }

        private void ClearAccTextBoxes()
        {
            List<TextBox> textBoxes = new List<TextBox> { AccNameTB, AccEmailTB, AccTimeTB, AccDateTB, AccRecordTB };
            AccountService.ClearTextboxes(textBoxes);
        }

        private void UpdateNumberRadios()
        {
            List<RadioButton> radioButtons = new List<RadioButton> { radioButton0, radioButton10, radioButton25, radioButtonOther };
            StringService.UpdateRadioButton(StringService.TryParseInt(textBoxN), radioButtons);
        }

        private void BinBindingData()
        {
            List<TextBox> textBoxes = new List<TextBox>
            {
                BinS_Textbox, BinN_Textbox,
                CreatedTimeTB, DeletedTimeTB,
                CreatedDateTB, DeletedDateTB
            };
            RecycleBinService.AddBinding(textBoxes, BinGridView);
        }

        private void AccBindingData()
        {
            List<TextBox> textBoxes = new List<TextBox>
            {
            AccNameTB, AccEmailTB, AccTimeTB, AccDateTB, AccRecordTB
            };
            AccountService.AddBinding(textBoxes, AccGridView);
        }

        private void ShowBinToolButtons()
        {
            List<Button> buttons = new List<Button> { RcvBTN, DltBTN };
            RecycleBinService.CheckAndUpdateRecycleBinButtons(BinGridView, buttons);
        }

        private void ShowAdminToolButtons()
        {
            List<Button> buttons = new List<Button> { AdminDeleteUserBTN };
            AccountService.CheckAndUpdateAdminButtons(AccGridView, buttons);
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

            if (!isBinding) // only clear selection if not in binding mode
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
                    UpdateNumberRadios();
                }
            }
            else
            {
                radioButtonOther.Checked = true;
            }
        }

        private void DecreaseBTN_Click(object sender, EventArgs e)
        {
            StringService.DecreaseNumber(textBoxN);
            int value = StringService.TryParseInt(textBoxN);
            UpdateNumberRadios();
            StringService.ValidateNumberInput(textBoxN, wrnLbl2);
            StringService.UpdateButtonState(textBoxN, IncreaseBTN, DecreaseBTN);
        }

        private void IncreaseBTN_Click(object sender, EventArgs e)
        {
            StringService.IncreaseNumber(textBoxN);
            int value = StringService.TryParseInt(textBoxN);
            UpdateNumberRadios();
            StringService.ValidateNumberInput(textBoxN, wrnLbl2);
            StringService.UpdateButtonState(textBoxN, IncreaseBTN, DecreaseBTN);
        }

        private void encodeBTN_Click(object sender, EventArgs e)
        {
            StringService.EncodingString(textBoxS, textBoxN);
            StringService.LoadAllDataFromDB(dataGridView);
            StringService.CountRecords(toolStripStatusLabel1);
            AccountService.LoadDataToGridView(AccGridView);
        }

        private void UppercaseBTN_Click(object sender, EventArgs e)
        {
            StringService.UpperCaseTextbox(textBoxS);
            StringService.CheckAndUpdateUppercaseButton(textBoxS, uppercaseBTN);
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row before deleting!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int originalID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ID"].Value);

            if (!IsConfirmed(originalID, "delete")) return;

            RecycleBinService.AddToRecycleBin(dataGridView, BinGridView);
            StringService.DeleteDataByID(dataGridView, DeleteBTN);
            StringService.CountRecords(toolStripStatusLabel1);
            StringService.ClearTextBoxes(textBoxS, textBoxN);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isBinding = true; // start binding
                StringService.addBinding(textBoxS, textBoxN, dataGridView);
                StringService.CheckAndUpdateDeleteButton(dataGridView, DeleteBTN);
                isBinding = false; // end binding
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            string filter = comboBox1.SelectedItem?.ToString() ?? "S";
            string searchText = SearchTB.Text.Trim().ToUpper();

            // If search box is empty, load all data from DB and clear the label
            if (string.IsNullOrWhiteSpace(searchText))
            {
                StringService.LoadAllDataFromDB(dataGridView);
                StringService.UpdateSearchLabel(searchWrnLbl, 0, searchText);
                return;
            }
            StringService.FilterData(filter, searchText, dataGridView);
            StringService.UpdateSearchLabel(searchWrnLbl, dataGridView.Rows.Count, searchText);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (!IsConfirmedForAll("delete")) return;
            StringService.ResetAllRecords(dataGridView);
            StringService.CountRecords(toolStripStatusLabel1);
            StringService.ClearTextBoxes(textBoxS, textBoxN);
            RecycleBinService.LoadAllDataFromDB(BinGridView);
            RecycleBinService.CountRecords(toolStripStatusLabel2);
        }

        private void radioButton10_click(object sender, EventArgs e)
        {
            StringService.UpdateTextBoxFromRadio(sender, textBoxN);
        }

        private void radioButton25_Click(object sender, EventArgs e)
        {
            StringService.UpdateTextBoxFromRadio(sender, textBoxN);
            StringService.UpdateButtonState(textBoxN, IncreaseBTN, DecreaseBTN);
        }

        private void radioButton0_Click(object sender, EventArgs e)
        {
            StringService.UpdateTextBoxFromRadio(sender, textBoxN);
        }

        private void clearInput_Click(object sender, EventArgs e)
        {
            StringService.ClearTextBoxes(textBoxS, textBoxN);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBoxN.Text = trackBar1.Value.ToString();
            UpdateNumberRadios();
        }

        private void BinGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isBinBinding = true; // start binding
                ClearBinTextBoxes();

                if (BinGridView.SelectedRows.Count > 0)
                {
                    BinBindingData();
                    RecycleBinService.UpdateGroupTitle(groupBox5, BinGridView);
                } 
                else
                {
                    ClearBinTextBoxes();
                    RecycleBinService.ClearGroupTitle(groupBox5);
                }
                ShowBinToolButtons();
                isBinBinding = false; // end binding
            }
        }

        private void AccGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isBinBinding = true; // start binding
                ClearAccTextBoxes();

                if (AccGridView.SelectedRows.Count > 0)
                {
                    AccBindingData();
                    AccountService.UpdateGroupTitle(groupBox8, AccGridView);
                }
                else
                {
                    ClearAccTextBoxes();
                    AccountService.ClearGroupTitle(groupBox8);
                }
                ShowAdminToolButtons();
                isBinBinding = false; // end binding
            }
        }


        private void RcvBTN_Click(object sender, EventArgs e)
        {
            int originalID = Convert.ToInt32(BinGridView.SelectedRows[0].Cells["ID"].Value);

            // confirm from user
            if (!IsConfirmed(originalID, "restore")) return;

            RecycleBinService.RestoreFromRecycleBin(BinGridView);
            RecycleBinService.ClearGroupTitle(groupBox5);
            RecycleBinService.CountRecords(toolStripStatusLabel2);

            StringService.CountRecords(toolStripStatusLabel1);
            StringService.LoadAllDataFromDB(dataGridView);
            ClearBinTextBoxes();
        }

        private void BinDltBTN_Click(object sender, EventArgs e)
        {
            int originalID = Convert.ToInt32(BinGridView.SelectedRows[0].Cells["ID"].Value);

            // confirm from user
            if (!IsConfirmed(originalID, "delete")) return;

            RecycleBinService.DeleteFromRecycleBin(BinGridView);
            ClearBinTextBoxes();
            RecycleBinService.ClearGroupTitle(groupBox5);
            RecycleBinService.CountRecords(toolStripStatusLabel2);
            ShowBinToolButtons();
        }

        private void DeletedAllBTN_Click(object sender, EventArgs e)
        {
            if (!IsConfirmedForAll("delete")) return;
            RecycleBinService.ClearRecycleBin(BinGridView);
            ClearBinTextBoxes();
            RecycleBinService.ClearGroupTitle(groupBox5);
        }

        private void RecoveryAllBTN_Click(object sender, EventArgs e)
        {
            if (!IsConfirmedForAll("restore")) return;
            RecycleBinService.RestoreAllFromRecycleBin(BinGridView);
            ClearBinTextBoxes();
            RecycleBinService.ClearGroupTitle(groupBox5);
            StringService.LoadAllDataFromDB(dataGridView);

            StringService.CountRecords(toolStripStatusLabel1);
            RecycleBinService.CountRecords(toolStripStatusLabel2);
        }

        private void BinSearchingTB_TextChanged(object sender, EventArgs e)
        {
            string filter = comboBox1.SelectedItem?.ToString() ?? "S";
            string SearchTxt = BinSearchingTB.Text.Trim().ToUpper();
            RecycleBinService.FilterData(filter, SearchTxt, BinGridView);
            RecycleBinService.UpdateSearchLabel(searchWrnLbl2, BinGridView.Rows.Count, SearchTxt);
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            AccountService.Logout();

            this.Hide();

            GUI_SignInForm signIn = new GUI_SignInForm();
            signIn.Show();
        }

        private void DeleteAcc_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure to delete your account, can't recover back!", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                AccountService.DeleteAndLogoutCurrentAccount(this);
            }
        }

        private void radioWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (RBWindow.Checked)
            {
                // safe Window mode
                var res = GetCurrentSetting();
                if (res.Mode == "Fullscreen")
                {
                SettingService.SaveMode("Window");
                    SettingService.ApplyMode(this, Width, Height);
                }

                // apply window mode immedialy
                SettingService.CenterTabControl(this);
                SettingService.BindSettingToControls(RBdarkmodeON, RBdarkmodeOff, RBWindow, RBFullscreen, Width, Height, Opacity);
            }
        }

        private void radioFullscreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RBFullscreen.Checked)
            {
                // save Fullscreen mode
                SettingService.SaveMode("Fullscreen");

                // apply fullscreen mode immedialy
                SettingService.ApplyMode(this, Width, Height);
                SettingService.CenterTabControl(this);
                SettingService.BindSettingToControls(RBdarkmodeON, RBdarkmodeOff, RBWindow, RBFullscreen, Width, Height, Opacity);
            }
        }

        private void RBdarkmodeON_CheckedChanged(object sender, EventArgs e)
        {
            bool isDarkMode = RBdarkmodeON.Checked;

            SettingService.ApplyDarkMode(
                new TabPage[] { tabPage1, tabPage2, tabPage3, tabPage4 },
                isDarkMode,
                this
            );
        }

        private void RBdarkmodeOff_CheckedChanged(object sender, EventArgs e)
        {
            bool isDarkMode = RBdarkmodeON.Checked;

            SettingService.ApplyDarkMode(
                new TabPage[] { tabPage1, tabPage2, tabPage3, tabPage4 },
                isDarkMode,
                this
            );
        }

        private void Width_ValueChanged(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(Width.Value);
            SettingService.UpdWidth(width, this);
        }

        private void Height_ValueChanged(object sender, EventArgs e)
        {
            int height = Convert.ToInt32(Height.Value);
            SettingService.UpdHeight(height, this);
        }

        private void OpacitytrackBar_Scroll(object sender, EventArgs e)
        {
            int opacityValue = Opacity.Value;
            SettingService.SaveOpacity(opacityValue);
            SettingService.ApplyOpacity(this); 
        }

        private void ResetSetting_Click(object sender, EventArgs e)
        {
            SettingService.ResetToDefault(this, new TabPage[] { tabPage1, tabPage2 },
                               RBdarkmodeOff,RBWindow, Width, Height, Opacity);
            StringService.LoadAllDataFromDB(dataGridView);
            RecycleBinService.LoadAllDataFromDB(BinGridView);
            AccountService.LoadDataToGridView(AccGridView);
        }

        private void UpdateAccInfo_Click(object sender, EventArgs e)
        {
            AccountService.OpenUpdateInfoForm(this);
            AccountService.LoadDataToGridView(AccGridView);
        }

        private void ChangePw_Click(object sender, EventArgs e)
        {
            GUI_ChangePasswordForm changePwForm = new GUI_ChangePasswordForm();
            changePwForm.Show();
        }

        private void DeleteUserAcc_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure to delete this user account, can't recover back!", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                int ID = (int)AccGridView.SelectedRows[0].Cells["ID"].Value;
                AccountService.DeleteUserAccByAdmin(ID);
                AccountService.LoadDataToGridView(AccGridView);
                AccountService.CountRecords(toolStripStatusLabel3);
                ClearAccTextBoxes();
                AccountService.ClearGroupTitle(groupBox8);
            }
        }

        private void DeleteAllUserAcc_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure to delete all user account, can't recover back!", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                // if null
                if (AccGridView.Rows.Count == 0)
                {
                    MessageBox.Show("No Account to move!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                AccountService.DeleteAllUserAcc();
                AccountService.LoadDataToGridView(AccGridView);
                AccountService.CountRecords(toolStripStatusLabel3);
            }
        }
    }
}