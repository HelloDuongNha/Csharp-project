using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Part1
{
    partial class GUI_OutputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WrnLbl4 = new System.Windows.Forms.Label();
            this.WrnLbl3 = new System.Windows.Forms.Label();
            this.WrnLbl2 = new System.Windows.Forms.Label();
            this.WrnLbl1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OutcodeTXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.InSortTXT = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.InCodeTXT = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.encodedTXT = new System.Windows.Forms.TextBox();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.WrnLbl4);
            this.groupBox2.Controls.Add(this.WrnLbl3);
            this.groupBox2.Controls.Add(this.WrnLbl2);
            this.groupBox2.Controls.Add(this.WrnLbl1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.OutcodeTXT);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.InSortTXT);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.InCodeTXT);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.encodedTXT);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(564, 165);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Area";
            // 
            // WrnLbl4
            // 
            this.WrnLbl4.AutoSize = true;
            this.WrnLbl4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.WrnLbl4.Location = new System.Drawing.Point(307, 141);
            this.WrnLbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WrnLbl4.Name = "WrnLbl4";
            this.WrnLbl4.Size = new System.Drawing.Size(77, 19);
            this.WrnLbl4.TabIndex = 10;
            this.WrnLbl4.Text = "                 ";
            // 
            // WrnLbl3
            // 
            this.WrnLbl3.AutoSize = true;
            this.WrnLbl3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.WrnLbl3.Location = new System.Drawing.Point(10, 141);
            this.WrnLbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WrnLbl3.Name = "WrnLbl3";
            this.WrnLbl3.Size = new System.Drawing.Size(77, 19);
            this.WrnLbl3.TabIndex = 11;
            this.WrnLbl3.Text = "                 ";
            // 
            // WrnLbl2
            // 
            this.WrnLbl2.AutoSize = true;
            this.WrnLbl2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.WrnLbl2.Location = new System.Drawing.Point(307, 73);
            this.WrnLbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WrnLbl2.Name = "WrnLbl2";
            this.WrnLbl2.Size = new System.Drawing.Size(77, 19);
            this.WrnLbl2.TabIndex = 9;
            this.WrnLbl2.Text = "                 ";
            // 
            // WrnLbl1
            // 
            this.WrnLbl1.AutoSize = true;
            this.WrnLbl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.WrnLbl1.Location = new System.Drawing.Point(10, 73);
            this.WrnLbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WrnLbl1.Name = "WrnLbl1";
            this.WrnLbl1.Size = new System.Drawing.Size(77, 19);
            this.WrnLbl1.TabIndex = 9;
            this.WrnLbl1.Text = "                 ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label10.Location = new System.Drawing.Point(307, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Output Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label8.Location = new System.Drawing.Point(10, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Input Sorted:";
            // 
            // OutcodeTXT
            // 
            this.OutcodeTXT.Enabled = false;
            this.OutcodeTXT.Location = new System.Drawing.Point(319, 114);
            this.OutcodeTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OutcodeTXT.Name = "OutcodeTXT";
            this.OutcodeTXT.Size = new System.Drawing.Size(183, 29);
            this.OutcodeTXT.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label9.Location = new System.Drawing.Point(307, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Input Code:";
            // 
            // InSortTXT
            // 
            this.InSortTXT.Enabled = false;
            this.InSortTXT.Location = new System.Drawing.Point(22, 46);
            this.InSortTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InSortTXT.Name = "InSortTXT";
            this.InSortTXT.Size = new System.Drawing.Size(183, 29);
            this.InSortTXT.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(503, 114);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(57, 30);
            this.button7.TabIndex = 7;
            this.button7.Text = "copy";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.Location = new System.Drawing.Point(10, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Encoded String:";
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(503, 46);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 29);
            this.button6.TabIndex = 7;
            this.button6.Text = "copy";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(207, 46);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 29);
            this.button5.TabIndex = 7;
            this.button5.Text = "copy";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // InCodeTXT
            // 
            this.InCodeTXT.Enabled = false;
            this.InCodeTXT.Location = new System.Drawing.Point(319, 46);
            this.InCodeTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InCodeTXT.Name = "InCodeTXT";
            this.InCodeTXT.Size = new System.Drawing.Size(183, 29);
            this.InCodeTXT.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(207, 114);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "copy";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // encodedTXT
            // 
            this.encodedTXT.Enabled = false;
            this.encodedTXT.Location = new System.Drawing.Point(22, 114);
            this.encodedTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.encodedTXT.Name = "encodedTXT";
            this.encodedTXT.Size = new System.Drawing.Size(183, 29);
            this.encodedTXT.TabIndex = 5;
            // 
            // ExitBTN
            // 
            this.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ExitBTN.Location = new System.Drawing.Point(195, 179);
            this.ExitBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(194, 26);
            this.ExitBTN.TabIndex = 5;
            this.ExitBTN.Text = "OK";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // GUI_OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 213);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.groupBox2);
            this.Name = "GUI_OutputForm";
            this.Text = "THE RESULT OF STRING PROCESSING";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private Label label10;
        private Label label8;
        private Label label9;
        private Button button7;
        private Label label7;
        private Button button6;
        private Button button5;
        private Button button4;
        public TextBox OutcodeTXT;
        public TextBox InSortTXT;
        public TextBox InCodeTXT;
        public TextBox encodedTXT;
        public Button ExitBTN;
        public Label WrnLbl1;
        public Label WrnLbl4;
        public Label WrnLbl3;
        public Label WrnLbl2;
    }
}