using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1.GUI
{
    public partial class GUI_UpdateAccInfoForm : Form
    {
        private GUI_InputForm _inputForm;
        public GUI_UpdateAccInfoForm(GUI_InputForm inputForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _inputForm = inputForm;
        }

        private void UpdateInfoBtn_Click(object sender, EventArgs e)
        {
            string newUsername = TBUpdateUsername.Text.Trim();
            string newEmail = TBUpdateEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newEmail))
            {
                MessageBox.Show("Username or Email cannot be empty.");
                return;
            }

            // Check if username already exists
            if (AccountService.isUsernameExist(newUsername))
            {
                MessageBox.Show("This username is already taken.");
                return;
            }

            // Check if email already exists
            if (AccountService.isEmailExist(newEmail))
            {
                MessageBox.Show("This email is already registered.");
                return;
            }

            // If valid, update info and bind to input form
            AccountService.SaveUpdatedAccountInfo(
                newUsername,
                newEmail,
                new List<TextBox> { _inputForm.UsernameIn4, _inputForm.EmailIn4 }
            );

            this.Close();
        }

        private void TBUpdateUsername_TextChanged(object sender, EventArgs e)
        {
            AccountService.CheckUsernameEmailExists(TBUpdateUsername, UsernameWrn, "Username");
        }

        private void TBUpdateEmail_TextChanged(object sender, EventArgs e)
        {
            AccountService.CheckUsernameEmailExists(TBUpdateEmail, EmailWrn, "Email");
        }
    }
}
