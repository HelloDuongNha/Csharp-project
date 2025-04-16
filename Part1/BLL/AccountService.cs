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

            // Username column
            DataGridViewTextBoxColumn inputSColumn = new DataGridViewTextBoxColumn();
            inputSColumn.Name = "Username";
            inputSColumn.HeaderText = "Username";
            inputSColumn.MinimumWidth = 130;
            inputSColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            inputSColumn.Resizable = DataGridViewTriState.False;

            AccGridView.Columns.Add(inputSColumn);

            // Email column
            DataGridViewTextBoxColumn inputNColumn = new DataGridViewTextBoxColumn();
            inputNColumn.Name = "Email";
            inputNColumn.HeaderText = "Email";
            inputNColumn.Width = 130;
            inputNColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AccGridView.Columns.Add(inputNColumn);

            // Record column
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
            Account acc = new Account();
            acc.Display(AccGridView);
            AccGridView.ClearSelection();
        }

        public static Account GetLoggedInAccDetails()
        {
            Account acc = new Account();
            var account = acc.GetLoggedInAccountDetails();
            return account;
        }

        private static int GetNextAccId()
        {
            Account acc = new Account();
            int nextId = acc.GetNextAccId();
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

        public static bool isCorrect(string name, string password)
        {
            Account acc = new Account();
            var account = acc.CheckLoginPassword(name, password);
            if (account != null)
            {
                acc.Login(name);
                return true;
            }
            return false;
        }

        public static bool isUsernameExist(string username)
        {
            Account acc = new Account();
            return acc.CheckUsernameExisted(username);
        }

        public static void Login(List<TextBox> textBoxes, Form CurrenForm)
        {
            string input = textBoxes[0].Text.Trim();
            string password = textBoxes[1].Text.Trim();

            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter Username or Email and Password!");
                return;
            }
            bool IsCorrect = isCorrect(input, password);

            if (IsCorrect)
            {
                MessageBox.Show("Login successful!");
                Account acc = new Account();
                acc.Login(input);

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
                MessageBox.Show("Incorrect Username/Email or Password!");
            }
        }

        public static void Logout()
        {
            Account acc = new Account();
            acc.Logout();
        }

        public static void BindLoggedInAccountToTextBoxes(List<TextBox> textBoxes)
        {
            var account = GetLoggedInAccDetails();
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
            Account acc = new Account();
            acc.DeleteThisAccount();

            // After deletion, open the login form again
            GUI_SignInForm signIn = new GUI_SignInForm();
            signIn.Show();

            // Close the current form
            currentForm.Close();
        }

        public static void DeleteAllUserAcc()
        {
            Account acc = new Account();
            acc.AdminDeleteAllAccounts();
        }

        public static void DeleteUserAccByAdmin(int UserId)
        {
            Account acc = new Account();
            acc.AdminDeleteAccountById(UserId);
        }

        public static void OpenUpdateInfoForm(GUI_InputForm inputForm)
        {
            var account = GetLoggedInAccDetails();

            if (account != null)
            {
                GUI_UpdateAccInfoForm updateForm = new GUI_UpdateAccInfoForm(inputForm);
                // Call method to bind data
                updateForm.TBUpdateUsername.Text = account.Username;
                updateForm.TBUpdateEmail.Text = account.Email;

                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No logged-in account found!");
            }
        }

        public static void SaveUpdatedAccountInfo(string newUsername, string newEmail, List<TextBox> boundTextBoxes)
        {
            Account acc = new Account();
            acc.EditAccount(newUsername, newEmail);
            BindLoggedInAccountToTextBoxes(boundTextBoxes);
            MessageBox.Show("Account information updated successfully!");
        }

        public static bool isCorrectToChangePassword(string currentPassword, string newPassword)
        {
            Account acc = new Account();
            return acc.ChangePassword(currentPassword, newPassword);
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

            Account acc = new Account();
            DateTime CreatedTime = acc.GetCreatedTimebById(ID) ?? DateTime.Now;
            textBoxes[2].Text = CreatedTime.ToString().Split(' ')[1]; // Time
            textBoxes[3].Text = CreatedTime.ToString().Split(' ')[0]; // Date

            textBoxes[4].Text = AccGridView.SelectedRows[0].Cells["Record"].Value?.ToString(); // Record
        }
    }
}