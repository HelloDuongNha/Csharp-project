using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1
{
    public partial class GUI_SignUpForm : Form
    {
        public GUI_SignUpForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            var inputList = new List<TextBox> { UserameTxt, EmailTxt, PwTxt, CfPwTxt };

            try
            {
                // Kiểm tra xem username và email đã tồn tại chưa
                string username = UserameTxt.Text.Trim();
                string email = EmailTxt.Text.Trim();

                if (AccountRepository.IsUsernameTaken(username))
                {
                    throw new Exception("Username already exists.");
                }

                if (AccountRepository.IsEmailTaken(email))
                {
                    throw new Exception("Email already exists.");
                }

                // Kiểm tra các điều kiện khác như độ dài và ký tự đặc biệt
                if (PwTxt.Text != CfPwTxt.Text)
                {
                    throw new Exception("Passwords do not match.");
                }

                // Tạo tài khoản nếu tất cả kiểm tra đều hợp lệ
                AccountService.CreateAccountFromForm(inputList);
                MessageBox.Show("Account created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            GUI_SignInForm signInForm = new GUI_SignInForm();
            signInForm.Show();
        }

        private void SeePwCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (seePwCheck.Checked)
            {
                // Nếu checkbox được chọn, hiển thị mật khẩu
                PwTxt.PasswordChar = '\0';  // \0 là ký tự null, nghĩa là không ẩn mật khẩu nữa
            }
            else
            {
                // Nếu checkbox không được chọn, ẩn mật khẩu bằng dấu *
                PwTxt.PasswordChar = '*';
            }
        }

        private void SeeCfPwCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SeeCfPwCheck.Checked)
            {
                // Nếu checkbox được chọn, hiển thị mật khẩu
                CfPwTxt.PasswordChar = '\0';  // \0 là ký tự null, nghĩa là không ẩn mật khẩu nữa
            }
            else
            {
                // Nếu checkbox không được chọn, ẩn mật khẩu bằng dấu *
                CfPwTxt.PasswordChar = '*';
            }
        }

        private void UserameTxt_TextChanged(object sender, EventArgs e)
        {
            string username = UserameTxt.Text.Trim();

            // Kiểm tra xem username có khoảng cách không
            if (string.IsNullOrWhiteSpace(username))
            {
                UsernameWrn.Text = "Username is required";
                UsernameWrn.ForeColor = Color.Red;
            }
            // Kiểm tra xem username có chứa khoảng trắng không
            else if (username.Contains(" "))
            {
                UsernameWrn.Text = "Username cannot contain spaces";
                UsernameWrn.ForeColor = Color.Red;
            }
            // Kiểm tra xem username có chỉ chứa ký tự a-z, A-Z, 0-9 không
            else if (!username.All(c => char.IsLetterOrDigit(c)))
            {
                UsernameWrn.Text = "Username can only contain letters and numbers (a-z, A-Z, 0-9)";
                UsernameWrn.ForeColor = Color.Red;
            }
            // Kiểm tra xem username đã tồn tại trong DB chưa
            else if (AccountRepository.IsUsernameTaken(username))
            {
                UsernameWrn.Text = "Username already taken";
                UsernameWrn.ForeColor = Color.Red;
            }
            else
            {
                UsernameWrn.Text = "Username is available";
                UsernameWrn.ForeColor = Color.Green;
            }
        }

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {
            string email = EmailTxt.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                EmailWrn.Text = "Email is required";
                EmailWrn.ForeColor = Color.Red;
            }
            else if (AccountRepository.IsEmailTaken(email))
            {
                EmailWrn.Text = "Email already taken";
                EmailWrn.ForeColor = Color.Red;
            }
            else
            {
                EmailWrn.Text = "Email is available";
                EmailWrn.ForeColor = Color.Green;
            }
        }



        private void PwTxt_TextChanged(object sender, EventArgs e)
        {
            string pw = PwTxt.Text;

            if (pw.Length < 6)
            {
                PwWrn.Text = "Password must be at least 6 characters";
                PwWrn.ForeColor = Color.Red;
            }
            else
            {
                PwWrn.Text = "Password is strong enough";
                PwWrn.ForeColor = Color.Green;
            }
        }

        private void CfPwTxt_TextChanged(object sender, EventArgs e)
        {
            string pw = PwTxt.Text;
            string cf = CfPwTxt.Text;

            if (cf != pw)
            {
                CfPwWrn.Text = "Passwords do not match";
                CfPwWrn.ForeColor = Color.Red;
            }
            else
            {
                CfPwWrn .Text = "Passwords match";
                CfPwWrn.ForeColor = Color.Green;
            }
        }
    }
}
