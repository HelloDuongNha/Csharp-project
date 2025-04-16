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
    public partial class GUI_ChangePasswordForm : Form
    {
        public GUI_ChangePasswordForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void UpdateInfoBtn_Click(object sender, EventArgs e)
        {
            string currentPassword = TBOldPassword.Text;
            string newPassword = TBNewPassword.Text;
            string confirmPassword = TBConfirmPassword.Text;

            // ##### CHECK FOR EMPTY FIELDS #####
            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Password fields cannot be empty.");
                return;
            }

            // ##### CHECK FOR SPACES IN NEW PASSWORD #####
            if (newPassword.Contains(" "))
            {
                MessageBox.Show("New password cannot contain spaces.");
                return;
            }

            // ##### CHECK THAT NEW PASSWORD IS DIFFERENT FROM CURRENT #####
            if (newPassword == currentPassword)
            {
                MessageBox.Show("New password cannot be the same as the current password.");
                return;
            }

            // ##### CHECK THAT NEW PASSWORD MATCHES CONFIRMATION #####
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password does not match the confirmation.");
                return;
            }

            // ##### ATTEMPT TO CHANGE PASSWORD #####
            bool result = AccountService.isCorrectToChangePassword(currentPassword, newPassword);

            if (result)
            {
                MessageBox.Show("Password changed successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("The current password is incorrect.");
            }
        }


        private void ForgotPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var account = AccountService.GetLoggedInAccDetails();
            if (account != null)
            {
                MessageBox.Show($"Your current password is: {account.Password}", "Current Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No logged-in account found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBOldPassword_TextChanged(object sender, EventArgs e)
        {
            string pw = TBOldPassword.Text;

            if (pw.Length < 6)
            {
                oldPwWrn.Text = "Password must be at least 6 characters";
                oldPwWrn.ForeColor = Color.Red;
            }
            else
            {
                oldPwWrn.Text = "";
            }
        }

        private void TBNewPassword_TextChanged(object sender, EventArgs e)
        {
            string oldPw = TBOldPassword.Text;
            string newPw = TBNewPassword.Text;

            if (newPw.Length < 6)
            {
                NewPwWrn.Text = "Password must be at least 6 characters";
                NewPwWrn.ForeColor = Color.Red;
            }
            else if (newPw.Contains(" "))
            {
                NewPwWrn.Text = "Password cannot contain spaces";
                NewPwWrn.ForeColor = Color.Red;
            }
            else if (newPw == oldPw)
            {
                NewPwWrn.Text = "New password cannot be the same as old password";
                NewPwWrn.ForeColor = Color.Red;
            }
            else
            {
                NewPwWrn.Text = "Password is valid";
                NewPwWrn.ForeColor = Color.Green;
            }
        }

        private void TBConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            string newPw = TBNewPassword.Text;
            string confirmPw = TBConfirmPassword.Text;

            if (confirmPw != newPw)
            {
                CFNewPwWrn.Text = "Passwords do not match";
                CFNewPwWrn.ForeColor = Color.Red;
            }
            else
            {
                CFNewPwWrn.Text = "Passwords match";
                CFNewPwWrn.ForeColor = Color.Green;
            }
        }

        private void SeeOldPwCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SeeOldPwCheck.Checked)
            {
                TBOldPassword.PasswordChar = '\0';
            }
            else
            {
                TBOldPassword.PasswordChar = '*';
            }
        }

        private void SeeNewPwCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SeeNewPwCheck.Checked)
            {
                TBNewPassword.PasswordChar = '\0';
            }
            else
            {
                TBNewPassword.PasswordChar = '*';
            }
        }

        private void SeeConfirmPwCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SeeConfirmPwCheck.Checked)
            {
                TBConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                TBConfirmPassword.PasswordChar = '*';
            }
        }

    }
}
