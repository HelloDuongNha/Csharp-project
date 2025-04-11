using System;
using System.Collections.Generic;
using System.Linq;
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
            if (textBoxes == null || textBoxes.Count < 4)
                throw new ArgumentException("Error: Must provide 4 textboxes (Username, Email, Password, Confirm Password).");

            int nextId = GetNextAccId();
            string username = textBoxes[0].Text.Trim();
            string email = textBoxes[1].Text.Trim();
            string password = textBoxes[2].Text;
            string confirmPassword = textBoxes[3].Text;

            //if (password != confirmPassword)
            //    throw new ArgumentException("Error: Password and Confirm Password do not match.");

            Account newAccount = new Account(nextId, username, email, password);

            newAccount.Add_Account(nextId, username, email, password);
        }
    }
}
