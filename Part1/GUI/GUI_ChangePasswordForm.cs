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

            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Không được để trống mật khẩu.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới không khớp.");
                return;
            }

            bool result = AccountService.ChangePassword(currentPassword, newPassword);

            if (result)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var account = AccountRepository.GetLoggedInAccount();
            if (account != null)
            {
                MessageBox.Show($"Mật khẩu hiện tại của bạn là: {account.Password}", "Mật khẩu hiện tại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản đang đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
