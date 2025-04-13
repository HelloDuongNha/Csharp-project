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
    public partial class GUI_OutputForm : Form
    {
        public GUI_OutputForm()
        {
            InitializeComponent();
        }
        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowLabel(TextBox textbox, Label label)
        {
            try
            {
                string textToCopy = textbox.Text;
                Clipboard.SetText(textToCopy);

                label.Text = "Success";
                label.ForeColor = Color.Green;
            }
            catch
            {
                label.Text = "Failed";
                label.ForeColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowLabel(InSortTXT, WrnLbl1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowLabel(InCodeTXT, WrnLbl2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowLabel(encodedTXT, WrnLbl3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowLabel(OutcodeTXT, WrnLbl4);
        }
    }
}
