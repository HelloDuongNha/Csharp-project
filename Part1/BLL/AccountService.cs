using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Part1.GUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Part1
{
    public static class AccountService
    {
        public static void SetupDataGridView(DataGridView AccGridView)
        {
            AccGridView.Columns.Clear();
            AccGridView.RowHeadersWidth = 30;
            AccGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            AccGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AccGridView.AllowUserToAddRows = false;

            // header style
            AccGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // ID column
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "ID";
            idColumn.Width = 25;
            idColumn.ReadOnly = true;
            idColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            idColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AccGridView.Columns.Add(idColumn);

            // S column
            DataGridViewTextBoxColumn inputSColumn = new DataGridViewTextBoxColumn();
            inputSColumn.Name = "Username";
            inputSColumn.HeaderText = "Username";
            inputSColumn.MinimumWidth = 130;
            //inputSColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //inputSColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            inputSColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            inputSColumn.Resizable = DataGridViewTriState.False;

            AccGridView.Columns.Add(inputSColumn);

            // N column
            DataGridViewTextBoxColumn inputNColumn = new DataGridViewTextBoxColumn();
            inputNColumn.Name = "Email";
            inputNColumn.HeaderText = "Email";
            inputNColumn.Width = 130;
            inputNColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //inputNColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AccGridView.Columns.Add(inputNColumn);

            // Dtime column
            DataGridViewTextBoxColumn deletedAtColumn = new DataGridViewTextBoxColumn();
            deletedAtColumn.Name = "Record";
            deletedAtColumn.HeaderText = "Records";
            deletedAtColumn.Width = 70;
            deletedAtColumn.ReadOnly = true;
            deletedAtColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deletedAtColumn.DefaultCellStyle.Font = new Font("Arial", 8);
            AccGridView.Columns.Add(deletedAtColumn);

            // header style
            AccGridView.EnableHeadersVisualStyles = false;
            AccGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            AccGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            AccGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            AccGridView.DefaultCellStyle.Font = new Font("Arial", 10);
        }

        public static void LoadDataToGridView(DataGridView AccGridView)
        {
            AccountRepository.Load_Data(AccGridView);
            AccGridView.ClearSelection();
        }

        private static int GetNextAccId()
        {
            int nextId = AccountRepository.GetNextAccountID();
            return nextId;
        }

        public static void CreateAccountFromForm(List<TextBox> textBoxes)
        {
            int nextId = GetNextAccId();
            string username = textBoxes[0].Text.Trim();
            string email = textBoxes[1].Text.Trim();
            string password = textBoxes[2].Text;
            string confirmPassword = textBoxes[3].Text;

            if (password != confirmPassword)
                throw new ArgumentException("Error: Password and Confirm Password do not match.");

            Account newAccount = new Account(nextId, username, email, password);

            newAccount.Add_Account(nextId, username, email, password);
        }

        public static bool isCorrect(string input, string password)
        {
            var account = AccountRepository.GetAccountByCredentials(input, password);
            if (account != null)
            {
                AccountRepository.SetLoginStatus(input, true);
                return true;
            }
            return false;
        }

        public static void Logout(string usernameOrEmail)
        {
            AccountRepository.SetLoginStatus(usernameOrEmail, false);
        }

        public static void Login(List<TextBox> textBoxes, Form CurrenForm)
        {
            string input = textBoxes[0].Text.Trim(); // Username hoặc Email
            string password = textBoxes[1].Text.Trim();

            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập Username hoặc Email và Password!");
                return;
            }
            bool IsCorrect = isCorrect(input, password);

            if (IsCorrect)
            {
                MessageBox.Show("Đăng nhập thành công!");
                AccountRepository.SetLoginStatus(input, true);

                CurrenForm.Hide();
                GUI_InputForm inputForm = new GUI_InputForm();
                inputForm.Show();
                List<TextBox> textBoxesInput = new List<TextBox>
                    {
                        inputForm.UsernameIn4,
                        inputForm.EmailIn4,
                        inputForm.TimeIn4,
                        inputForm.DateIn4
                    };
                BindLoggedInAccountToTextBoxes(textBoxesInput);
            }
            else
            {
                MessageBox.Show("Sai Username/Email hoặc Password!");
            }
        }

        public static void Logout()
        {
            AccountRepository.LogOutCurrentUser();
        }

        public static void BindLoggedInAccountToTextBoxes(List<TextBox> textBoxes)
        {
            var account = AccountRepository.GetLoggedInAccount();
            if (account != null)
            {
                if (textBoxes.Count > 0) textBoxes[0].Text = account.Username;
                if (textBoxes.Count > 1) textBoxes[1].Text = account.Email;
                if (textBoxes.Count > 2) textBoxes[2].Text = account.CreatedTime?.ToString().Split(' ')[1];
                if (textBoxes.Count > 3) textBoxes[3].Text = account.CreatedTime?.ToString().Split(' ')[0];
            }
        }

        public static void DeleteAndLogoutCurrentAccount(Form currentForm)
        {
            AccountRepository.DeleteAccountByLogin();

            // Sau khi xóa, mở lại form đăng nhập
            GUI_SignInForm signIn = new GUI_SignInForm();
            signIn.Show();

            // Ẩn form hiện tại
            currentForm.Hide();
        }

        public static void DeleteAllUserAcc()
        {
            AccountRepository.DeleteAllUserAccounts();
        }

        public static void DeleteUserAccByAdmin(int UserId)
        {
            AccountRepository.DeleteAccountById(UserId);
        }

        public static void OpenUpdateInfoForm(GUI_InputForm inputForm)
        {
            var account = AccountRepository.GetLoggedInAccount();

            if (account != null)
            {

                GUI_UpdateAccInfoForm updateForm = new GUI_UpdateAccInfoForm(inputForm);
                // Gọi method để binding dữ liệu
                updateForm.TBUpdateUsername.Text = account.Username;
                updateForm.TBUpdateEmail.Text = account.Email; 

                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản đang đăng nhập!");
            }
        }

        public static void SaveUpdatedAccountInfo(string newUsername, string newEmail, List<TextBox> boundTextBoxes)
        {
            AccountRepository.UpdateLoggedInAccountInfo(newUsername, newEmail);
            BindLoggedInAccountToTextBoxes(boundTextBoxes);
            MessageBox.Show("Cập nhật thông tin thành công!");
        }

        public static bool ChangePassword(string currentPassword, string newPassword)
        {
            return AccountRepository.ChangePasswordForLoggedInUser(currentPassword, newPassword);
        }
        public static void ClearTextboxes(List<TextBox> textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.DataBindings.Clear();
                textBox.Clear();
            }
        }

        public static void AddBinding(List<TextBox> textBoxes, DataGridView AccGridView)
        {
            if (textBoxes == null || textBoxes.Count == 0)
                throw new ArgumentException("Error: The list must contain at least one textbox.");

            // name and email binding
            textBoxes[0].Text = AccGridView.SelectedRows[0].Cells["Username"].Value?.ToString();
            textBoxes[1].Text = AccGridView.SelectedRows[0].Cells["Email"].Value?.ToString();

            // Time Binding
            int ID = (int)AccGridView.SelectedRows[0].Cells["ID"].Value;
            DateTime CreatedTime = AccountRepository.GetCreatedTimeById(ID) ?? DateTime.Now;
            textBoxes[2].Text = CreatedTime.ToString().Split(' ')[1]; // Time
            textBoxes[3].Text = CreatedTime.ToString().Split(' ')[0]; // Date

            textBoxes[4].Text = AccGridView.SelectedRows[0].Cells["Record"].Value?.ToString(); // Record
        }
    }
}
