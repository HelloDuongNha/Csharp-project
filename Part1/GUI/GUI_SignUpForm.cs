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

        private void button1_Click(object sender, EventArgs e)
        {
            var inputList = new List<TextBox> { UserameTxt, EmailTxt, PwTxt, CfPwTxt };

            try
            {
                AccountService.CreateAccountFromForm(inputList);
                MessageBox.Show("Account created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            GUI_SignInForm signInForm = new GUI_SignInForm();
            signInForm.Show();
        }
    }
}
