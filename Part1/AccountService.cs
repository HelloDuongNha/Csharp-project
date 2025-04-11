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
            Account account = new Account();
            int nextId = account.GetNextAccId();
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
                Input_Form inputForm = new Input_Form();
                inputForm.Show();
            }
            else
            {
                MessageBox.Show("Sai Username/Email hoặc Password!");
            }
        }
    }
}
