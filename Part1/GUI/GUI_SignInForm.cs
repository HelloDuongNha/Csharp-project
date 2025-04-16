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
    public partial class GUI_SignInForm : Form
    {
        public GUI_SignInForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            List<TextBox> inputList = new List<TextBox> { UsernameTxt, PwTxt };
            AccountService.Login(inputList, this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); 

            GUI_SignUpForm signUpForm = new GUI_SignUpForm();
            signUpForm.Show();
        }

        private void SeePWcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SeePWcheck.Checked)
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

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text.Trim();

            // Kiểm tra xem username có khoảng cách không
            if (username.Contains(" "))
            {
                LoginUsernameWrn.Text = "Username cannot contain spaces";
                LoginUsernameWrn.ForeColor = Color.Red;
            }
            // Kiểm tra xem username có chỉ chứa ký tự a-z hay không
            else if (!username.All(c => char.IsLetterOrDigit(c)))
            {
                LoginUsernameWrn.Text = "Username must only contain letters (a-z)";
                LoginUsernameWrn.ForeColor = Color.Red;
            }
            // Kiểm tra xem username đã tồn tại trong DB chưa
            else if (AccountService.isUsernameExist(username))
            {
                LoginUsernameWrn.Text = "Username is valid";
                LoginUsernameWrn.ForeColor = Color.Green;
            }
            else
            {
                LoginUsernameWrn.Text = "This Username isn't existed";
                LoginUsernameWrn.ForeColor = Color.Red;
            }
        }

        private void PwTxt_TextChanged(object sender, EventArgs e)
        {
            string pw = PwTxt.Text;

            // Kiểm tra độ dài mật khẩu
            if (pw.Length < 6)
            {
                LoginPwWrn.Text = "Password must be at least 6 characters";
                LoginPwWrn.ForeColor = Color.Red;
            }
            else if (pw.Length > 20)
            {
                LoginPwWrn.Text = "Password must be at most 20 characters";
                LoginPwWrn.ForeColor = Color.Red;
            }
            else
            {
                LoginPwWrn.Text = "Password is valid";
                LoginPwWrn.ForeColor = Color.Green;
            }
        }
    }
}
