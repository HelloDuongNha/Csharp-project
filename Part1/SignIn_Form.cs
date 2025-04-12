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
    public partial class SignIn_Form : Form
    {
        public SignIn_Form()
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

            SignUp_Form signUpForm = new SignUp_Form();
            signUpForm.Show();
        }
    }
}
