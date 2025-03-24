using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Part1
{
    partial class Input_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button9 = new System.Windows.Forms.Button();
            this.encodeBTN = new System.Windows.Forms.Button();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.DecreaseBTN = new System.Windows.Forms.Button();
            this.IncreaseBTN = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wrnLbl2 = new System.Windows.Forms.Label();
            this.wrnLb1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchWrnLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Search = new System.Windows.Forms.TextBox();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.uppercaseBTN = new System.Windows.Forms.Button();
            this.CountLbl = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(477, 706);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(291, 40);
            this.button9.TabIndex = 4;
            this.button9.Text = "CLEAR ALL";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // encodeBTN
            // 
            this.encodeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encodeBTN.Location = new System.Drawing.Point(116, 326);
            this.encodeBTN.Name = "encodeBTN";
            this.encodeBTN.Size = new System.Drawing.Size(213, 45);
            this.encodeBTN.TabIndex = 2;
            this.encodeBTN.Text = "ENCODE";
            this.encodeBTN.UseVisualStyleBackColor = true;
            this.encodeBTN.Click += new System.EventHandler(this.encodeBTN_Click);
            // 
            // ResetBTN
            // 
            this.ResetBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ResetBTN.Location = new System.Drawing.Point(32, 508);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(106, 42);
            this.ResetBTN.TabIndex = 7;
            this.ResetBTN.Text = "Reset";
            this.ResetBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.Reset_Click);
            // 
            // DecreaseBTN
            // 
            this.DecreaseBTN.Location = new System.Drawing.Point(20, 37);
            this.DecreaseBTN.Name = "DecreaseBTN";
            this.DecreaseBTN.Size = new System.Drawing.Size(45, 51);
            this.DecreaseBTN.TabIndex = 7;
            this.DecreaseBTN.Text = "-";
            this.DecreaseBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DecreaseBTN.UseVisualStyleBackColor = true;
            this.DecreaseBTN.Click += new System.EventHandler(this.DecreaseBTN_Click);
            // 
            // IncreaseBTN
            // 
            this.IncreaseBTN.Location = new System.Drawing.Point(125, 36);
            this.IncreaseBTN.Name = "IncreaseBTN";
            this.IncreaseBTN.Size = new System.Drawing.Size(45, 51);
            this.IncreaseBTN.TabIndex = 7;
            this.IncreaseBTN.Text = "+";
            this.IncreaseBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IncreaseBTN.UseVisualStyleBackColor = true;
            this.IncreaseBTN.Click += new System.EventHandler(this.IncreaseBTN_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(69, 37);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(50, 39);
            this.textBoxN.TabIndex = 2;
            this.textBoxN.Text = "0";
            this.textBoxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxN.TextChanged += new System.EventHandler(this.textBoxN_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number N:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "String S:";
            // 
            // wrnLbl2
            // 
            this.wrnLbl2.AutoSize = true;
            this.wrnLbl2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.wrnLbl2.ForeColor = System.Drawing.Color.Green;
            this.wrnLbl2.Location = new System.Drawing.Point(22, 91);
            this.wrnLbl2.Name = "wrnLbl2";
            this.wrnLbl2.Size = new System.Drawing.Size(73, 21);
            this.wrnLbl2.TabIndex = 3;
            this.wrnLbl2.Text = "✅ Valid.";
            // 
            // wrnLb1
            // 
            this.wrnLb1.AutoSize = true;
            this.wrnLb1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.wrnLb1.ForeColor = System.Drawing.Color.Red;
            this.wrnLb1.Location = new System.Drawing.Point(22, 82);
            this.wrnLb1.Name = "wrnLb1";
            this.wrnLb1.Size = new System.Drawing.Size(158, 21);
            this.wrnLb1.TabIndex = 3;
            this.wrnLb1.Text = "❎ Cannot be empty.";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.searchWrnLbl);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.DeleteBTN);
            this.groupBox1.Controls.Add(this.ResetBTN);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 600);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT HISTORY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(28, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Search:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(500, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "filter by:";
            // 
            // searchWrnLbl
            // 
            this.searchWrnLbl.AutoSize = true;
            this.searchWrnLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.searchWrnLbl.ForeColor = System.Drawing.Color.Red;
            this.searchWrnLbl.Location = new System.Drawing.Point(38, 124);
            this.searchWrnLbl.Name = "searchWrnLbl";
            this.searchWrnLbl.Size = new System.Drawing.Size(118, 21);
            this.searchWrnLbl.TabIndex = 14;
            this.searchWrnLbl.Text = "                           ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "S",
            "N"});
            this.comboBox1.Location = new System.Drawing.Point(504, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 40);
            this.comboBox1.TabIndex = 13;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(140, 32);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 25);
            this.toolStripStatusLabel1.Text = "Total Record: ";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Search.Location = new System.Drawing.Point(32, 69);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(461, 39);
            this.Search.TabIndex = 12;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteBTN.Location = new System.Drawing.Point(504, 508);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(106, 42);
            this.DeleteBTN.TabIndex = 7;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle45;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle46;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(32, 150);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(578, 350);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBoxN);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.IncreaseBTN);
            this.panel3.Controls.Add(this.wrnLbl2);
            this.panel3.Controls.Add(this.DecreaseBTN);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(26, 151);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 167);
            this.panel3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonOther);
            this.panel1.Controls.Add(this.radioButton25);
            this.panel1.Controls.Add(this.radioButton10);
            this.panel1.Controls.Add(this.radioButton0);
            this.panel1.Location = new System.Drawing.Point(138, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 40);
            this.panel1.TabIndex = 8;
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonOther.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.radioButtonOther.Location = new System.Drawing.Point(170, 5);
            this.radioButtonOther.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(76, 25);
            this.radioButtonOther.TabIndex = 0;
            this.radioButtonOther.Text = "other";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            // 
            // radioButton25
            // 
            this.radioButton25.AutoSize = true;
            this.radioButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton25.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.radioButton25.Location = new System.Drawing.Point(114, 5);
            this.radioButton25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(53, 25);
            this.radioButton25.TabIndex = 0;
            this.radioButton25.Text = "25";
            this.radioButton25.UseVisualStyleBackColor = true;
            this.radioButton25.Click += new System.EventHandler(this.radioButton25_Click);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton10.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.radioButton10.Location = new System.Drawing.Point(58, 5);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(53, 25);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.Text = "10";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.Click += new System.EventHandler(this.radioButton10_click);
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.Checked = true;
            this.radioButton0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton0.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.radioButton0.Location = new System.Drawing.Point(4, 5);
            this.radioButton0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(44, 25);
            this.radioButton0.TabIndex = 0;
            this.radioButton0.TabStop = true;
            this.radioButton0.Text = "0";
            this.radioButton0.UseVisualStyleBackColor = true;
            this.radioButton0.Click += new System.EventHandler(this.radioButton0_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quick Number:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxS);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.uppercaseBTN);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.CountLbl);
            this.panel2.Controls.Add(this.wrnLb1);
            this.panel2.Location = new System.Drawing.Point(26, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 112);
            this.panel2.TabIndex = 9;
            // 
            // textBoxS
            // 
            this.textBoxS.AcceptsTab = true;
            this.textBoxS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxS.Location = new System.Drawing.Point(20, 38);
            this.textBoxS.Multiline = true;
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(302, 33);
            this.textBoxS.TabIndex = 1;
            this.textBoxS.TextChanged += new System.EventHandler(this.textBoxS_TextChanged);
            // 
            // uppercaseBTN
            // 
            this.uppercaseBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uppercaseBTN.Location = new System.Drawing.Point(-1500, -1538);
            this.uppercaseBTN.Name = "uppercaseBTN";
            this.uppercaseBTN.Size = new System.Drawing.Size(62, 43);
            this.uppercaseBTN.TabIndex = 2;
            this.uppercaseBTN.Text = "⇧";
            this.uppercaseBTN.UseVisualStyleBackColor = true;
            this.uppercaseBTN.Click += new System.EventHandler(this.UppercaseBTN_Click);
            // 
            // CountLbl
            // 
            this.CountLbl.AutoSize = true;
            this.CountLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CountLbl.Location = new System.Drawing.Point(224, 9);
            this.CountLbl.Name = "CountLbl";
            this.CountLbl.Size = new System.Drawing.Size(102, 21);
            this.CountLbl.TabIndex = 3;
            this.CountLbl.Text = "Length: 0/40 ";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1126, 645);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Homepage";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox3.Location = new System.Drawing.Point(674, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(435, 212);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " INPUT REQUIREMENT FOR USER";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox3.Location = new System.Drawing.Point(254, 66);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 135);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "- Must be a number between -25 and 25.\r\n- Determines how much each letter shifts " +
    "in encoding.";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox2.Location = new System.Drawing.Point(9, 66);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 135);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "- Must be ALL capital letters (A-Z).\r\n- Maximum 40 characters.\r\n- No lowercase le" +
    "tters, numbers, or special characters.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(290, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Integer (N)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(76, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "String (S)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.encodeBTN);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(674, 245);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(435, 378);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INPUT AREA";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1126, 645);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.Location = new System.Drawing.Point(16, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1134, 683);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1126, 645);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Recently Deleted";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Controls.Add(this.panel7);
            this.groupBox5.Controls.Add(this.panel6);
            this.groupBox5.Controls.Add(this.panel5);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(677, 153);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(423, 470);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Details (ID: )";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.statusStrip3);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(22, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(631, 600);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(29, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "                           ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(29, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Search:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(501, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "filter by:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ID",
            "S",
            "N"});
            this.comboBox2.Location = new System.Drawing.Point(505, 78);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(102, 40);
            this.comboBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(33, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 39);
            this.textBox1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(455, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Delete All";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(33, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Recovery All";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle48;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(33, 159);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(578, 350);
            this.dataGridView1.TabIndex = 17;
            // 
            // statusStrip3
            // 
            this.statusStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip3.Location = new System.Drawing.Point(4, 570);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Padding = new System.Windows.Forms.Padding(2, 0, 18, 0);
            this.statusStrip3.Size = new System.Drawing.Size(140, 32);
            this.statusStrip3.TabIndex = 18;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 25);
            this.toolStripStatusLabel2.Text = "Total Record: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(40, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 32);
            this.label8.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(104, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "Clear";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.clearInput_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(203, 40);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Minimum = -25;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(168, 69);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox5);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Location = new System.Drawing.Point(7, 143);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(409, 90);
            this.panel5.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.AcceptsTab = true;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox5.Location = new System.Drawing.Point(20, 38);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(302, 33);
            this.textBox5.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label14.Location = new System.Drawing.Point(3, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 28);
            this.label14.TabIndex = 4;
            this.label14.Text = "Number N:";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(-1500, -1538);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 43);
            this.button5.TabIndex = 2;
            this.button5.Text = "⇧";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox6);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Location = new System.Drawing.Point(7, 54);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(409, 90);
            this.panel6.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.AcceptsTab = true;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBox6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox6.Location = new System.Drawing.Point(20, 38);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(302, 33);
            this.textBox6.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label16.Location = new System.Drawing.Point(3, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 28);
            this.label16.TabIndex = 4;
            this.label16.Text = "String S:";
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(-1500, -1538);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 43);
            this.button6.TabIndex = 2;
            this.button6.Text = "⇧";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label17.Location = new System.Drawing.Point(224, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 21);
            this.label17.TabIndex = 3;
            this.label17.Text = "Length: 0/40 ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox4);
            this.panel7.Controls.Add(this.textBox7);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.button7);
            this.panel7.Location = new System.Drawing.Point(7, 274);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(409, 90);
            this.panel7.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.AcceptsTab = true;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBox7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox7.Location = new System.Drawing.Point(8, 36);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(165, 33);
            this.textBox7.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label18.Location = new System.Drawing.Point(28, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 28);
            this.label18.TabIndex = 4;
            this.label18.Text = "Encoded at";
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(-1500, -1538);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 43);
            this.button7.TabIndex = 2;
            this.button7.Text = "⇧";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.AcceptsTab = true;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Location = new System.Drawing.Point(228, 38);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 33);
            this.textBox4.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label12.Location = new System.Drawing.Point(253, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 28);
            this.label12.TabIndex = 4;
            this.label12.Text = "Deleted at";
            // 
            // Input_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 760);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button9);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Input_Form";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button9;
        private Button encodeBTN;
        private Button ResetBTN;
        private Button DecreaseBTN;
        private Button IncreaseBTN;
        private TextBox textBoxN;
        private Label label4;
        private Label label3;
        private Label wrnLbl2;
        private Label wrnLb1;
        private GroupBox groupBox1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl tabControl1;
        private Label CountLbl;
        private Panel panel1;
        private RadioButton radioButtonOther;
        private RadioButton radioButton25;
        private RadioButton radioButton10;
        private RadioButton radioButton0;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView;
        private GroupBox groupBox2;
        private TextBox Search;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button DeleteBTN;
        private TextBox textBoxS;
        private Button uppercaseBTN;
        private GroupBox groupBox3;
        private Label label2;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        //private StringProcessingDataSet stringProcessingDataSet;
        //private BindingSource stringsHistoryBindingSource;
        //private StringProcessingDataSetTableAdapters.StringsHistoryTableAdapter stringsHistoryTableAdapter;
        //private StringProcessingDBDataSet3 stringProcessingDBDataSet3;
        //private BindingSource stringsHistoriesBindingSource;
        //private StringProcessingDBDataSet3TableAdapters.StringsHistoriesTableAdapter stringsHistoriesTableAdapter;
        //private StringProcessingDBDataSet4 stringProcessingDBDataSet4;
        //private BindingSource stringsHistoriesBindingSource1;
        //private StringProcessingDBDataSet4TableAdapters.StringsHistoriesTableAdapter stringsHistoriesTableAdapter1;
        protected ComboBox comboBox1;
        private Label searchWrnLbl;
        private Label label6;
        private Label label7;
        private TabPage tabPage3;
        private GroupBox groupBox4;
        private Label label8;
        private Label label11;
        private Label label10;
        private Label label9;
        protected ComboBox comboBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private StatusStrip statusStrip3;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private GroupBox groupBox5;
        private Button button3;
        private TrackBar trackBar1;
        private Panel panel7;
        private TextBox textBox4;
        private TextBox textBox7;
        private Label label12;
        private Label label18;
        private Button button7;
        private Panel panel6;
        private TextBox textBox6;
        private Label label16;
        private Button button6;
        private Label label17;
        private Panel panel5;
        private TextBox textBox5;
        private Label label14;
        private Button button5;
    }
}
