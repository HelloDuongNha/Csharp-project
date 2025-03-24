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
    public partial class Output_Form : Form
    {
        public Output_Form()
        {
            InitializeComponent();
        }
        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
