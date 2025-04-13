using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1
{
    public static class AccountService
    {
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
            if (!(account == null))
            {
                textBoxes[0].Text = account.Username;
                textBoxes[1].Text = account.Email;
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

    }
}
