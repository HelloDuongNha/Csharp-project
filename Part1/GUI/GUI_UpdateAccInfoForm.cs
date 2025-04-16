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
                MessageBox.Show("Không được để trống Username hoặc Email.");
                return;
            }

            // Gọi hàm cập nhật từ AccountService
            AccountService.SaveUpdatedAccountInfo(
                newUsername,
                newEmail,
                new List<TextBox> { _inputForm.UsernameIn4, _inputForm.EmailIn4 } // bind lại form cha
            );
            this.Close();
        }
    }
}
