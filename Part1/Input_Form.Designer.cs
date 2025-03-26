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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.uppercaseBTN = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.DltBTN = new System.Windows.Forms.Button();
            this.RcvBTN = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DeletedDateTB = new System.Windows.Forms.TextBox();
            this.DeletedTimeTB = new System.Windows.Forms.TextBox();
            this.CreatedDateTB = new System.Windows.Forms.TextBox();
            this.CreatedTimeTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BinS_Textbox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BinN_Textbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BinFilterCbb = new System.Windows.Forms.ComboBox();
            this.BinSearchingTB = new System.Windows.Forms.TextBox();
            this.DeletedAllBTN = new System.Windows.Forms.Button();
            this.RecoveryAllBTN = new System.Windows.Forms.Button();
            this.BinGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BinGridView)).BeginInit();
            this.statusStrip3.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.uppercaseBTN.Location = new System.Drawing.Point(328, 33);
            this.uppercaseBTN.Name = "uppercaseBTN";
            this.uppercaseBTN.Size = new System.Drawing.Size(62, 43);
            this.uppercaseBTN.TabIndex = 2;
            this.uppercaseBTN.Text = "⇧";
            this.uppercaseBTN.UseVisualStyleBackColor = true;
            this.uppercaseBTN.Click += new System.EventHandler(this.UppercaseBTN_Click);
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
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.clearInput_Click);
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
            this.groupBox5.Controls.Add(this.DltBTN);
            this.groupBox5.Controls.Add(this.RcvBTN);
            this.groupBox5.Controls.Add(this.panel7);
            this.groupBox5.Controls.Add(this.panel6);
            this.groupBox5.Controls.Add(this.panel5);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(761, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 602);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Details (ID: )";
            // 
            // DltBTN
            // 
            this.DltBTN.BackColor = System.Drawing.Color.LightCoral;
            this.DltBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DltBTN.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.DltBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DltBTN.Location = new System.Drawing.Point(7, 538);
            this.DltBTN.Name = "DltBTN";
            this.DltBTN.Size = new System.Drawing.Size(320, 50);
            this.DltBTN.TabIndex = 17;
            this.DltBTN.Text = "Delete";
            this.DltBTN.UseVisualStyleBackColor = false;
            // 
            // RcvBTN
            // 
            this.RcvBTN.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.RcvBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RcvBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.RcvBTN.Location = new System.Drawing.Point(7, 481);
            this.RcvBTN.Name = "RcvBTN";
            this.RcvBTN.Size = new System.Drawing.Size(320, 51);
            this.RcvBTN.TabIndex = 18;
            this.RcvBTN.Text = "Recovery";
            this.RcvBTN.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.DeletedDateTB);
            this.panel7.Controls.Add(this.DeletedTimeTB);
            this.panel7.Controls.Add(this.CreatedDateTB);
            this.panel7.Controls.Add(this.CreatedTimeTB);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.button7);
            this.panel7.Location = new System.Drawing.Point(7, 242);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(326, 184);
            this.panel7.TabIndex = 10;
            // 
            // DeletedDateTB
            // 
            this.DeletedDateTB.AcceptsTab = true;
            this.DeletedDateTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.DeletedDateTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeletedDateTB.Location = new System.Drawing.Point(173, 116);
            this.DeletedDateTB.Multiline = true;
            this.DeletedDateTB.Name = "DeletedDateTB";
            this.DeletedDateTB.Size = new System.Drawing.Size(147, 33);
            this.DeletedDateTB.TabIndex = 1;
            // 
            // DeletedTimeTB
            // 
            this.DeletedTimeTB.AcceptsTab = true;
            this.DeletedTimeTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.DeletedTimeTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeletedTimeTB.Location = new System.Drawing.Point(20, 116);
            this.DeletedTimeTB.Multiline = true;
            this.DeletedTimeTB.Name = "DeletedTimeTB";
            this.DeletedTimeTB.Size = new System.Drawing.Size(147, 33);
            this.DeletedTimeTB.TabIndex = 1;
            // 
            // CreatedDateTB
            // 
            this.CreatedDateTB.AcceptsTab = true;
            this.CreatedDateTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.CreatedDateTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CreatedDateTB.Location = new System.Drawing.Point(173, 34);
            this.CreatedDateTB.Multiline = true;
            this.CreatedDateTB.Name = "CreatedDateTB";
            this.CreatedDateTB.Size = new System.Drawing.Size(147, 33);
            this.CreatedDateTB.TabIndex = 1;
            // 
            // CreatedTimeTB
            // 
            this.CreatedTimeTB.AcceptsTab = true;
            this.CreatedTimeTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.CreatedTimeTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CreatedTimeTB.Location = new System.Drawing.Point(20, 34);
            this.CreatedTimeTB.Multiline = true;
            this.CreatedTimeTB.Name = "CreatedTimeTB";
            this.CreatedTimeTB.Size = new System.Drawing.Size(147, 33);
            this.CreatedTimeTB.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label12.Location = new System.Drawing.Point(3, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 28);
            this.label12.TabIndex = 4;
            this.label12.Text = "Deleted at";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label18.Location = new System.Drawing.Point(3, 3);
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
            // panel6
            // 
            this.panel6.Controls.Add(this.BinS_Textbox);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Location = new System.Drawing.Point(7, 56);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(326, 90);
            this.panel6.TabIndex = 10;
            // 
            // BinS_Textbox
            // 
            this.BinS_Textbox.AcceptsTab = true;
            this.BinS_Textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.BinS_Textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BinS_Textbox.Location = new System.Drawing.Point(20, 36);
            this.BinS_Textbox.Multiline = true;
            this.BinS_Textbox.Name = "BinS_Textbox";
            this.BinS_Textbox.Size = new System.Drawing.Size(302, 33);
            this.BinS_Textbox.TabIndex = 1;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.BinN_Textbox);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Location = new System.Drawing.Point(7, 145);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(326, 90);
            this.panel5.TabIndex = 10;
            // 
            // BinN_Textbox
            // 
            this.BinN_Textbox.AcceptsTab = true;
            this.BinN_Textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.BinN_Textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BinN_Textbox.Location = new System.Drawing.Point(20, 38);
            this.BinN_Textbox.Multiline = true;
            this.BinN_Textbox.Name = "BinN_Textbox";
            this.BinN_Textbox.Size = new System.Drawing.Size(302, 33);
            this.BinN_Textbox.TabIndex = 1;
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
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.BinFilterCbb);
            this.groupBox4.Controls.Add(this.BinSearchingTB);
            this.groupBox4.Controls.Add(this.DeletedAllBTN);
            this.groupBox4.Controls.Add(this.RecoveryAllBTN);
            this.groupBox4.Controls.Add(this.BinGridView);
            this.groupBox4.Controls.Add(this.statusStrip3);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(22, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(719, 600);
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
            this.label9.Location = new System.Drawing.Point(584, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "filter by:";
            // 
            // BinFilterCbb
            // 
            this.BinFilterCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BinFilterCbb.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BinFilterCbb.FormattingEnabled = true;
            this.BinFilterCbb.Items.AddRange(new object[] {
            "ID",
            "S",
            "N"});
            this.BinFilterCbb.Location = new System.Drawing.Point(588, 77);
            this.BinFilterCbb.Name = "BinFilterCbb";
            this.BinFilterCbb.Size = new System.Drawing.Size(102, 40);
            this.BinFilterCbb.TabIndex = 20;
            // 
            // BinSearchingTB
            // 
            this.BinSearchingTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BinSearchingTB.Location = new System.Drawing.Point(33, 78);
            this.BinSearchingTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BinSearchingTB.Name = "BinSearchingTB";
            this.BinSearchingTB.Size = new System.Drawing.Size(544, 39);
            this.BinSearchingTB.TabIndex = 19;
            // 
            // DeletedAllBTN
            // 
            this.DeletedAllBTN.BackColor = System.Drawing.Color.LightCoral;
            this.DeletedAllBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletedAllBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DeletedAllBTN.Location = new System.Drawing.Point(33, 517);
            this.DeletedAllBTN.Name = "DeletedAllBTN";
            this.DeletedAllBTN.Size = new System.Drawing.Size(156, 42);
            this.DeletedAllBTN.TabIndex = 15;
            this.DeletedAllBTN.Text = "Delete All";
            this.DeletedAllBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeletedAllBTN.UseVisualStyleBackColor = false;
            // 
            // RecoveryAllBTN
            // 
            this.RecoveryAllBTN.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.RecoveryAllBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecoveryAllBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.RecoveryAllBTN.Location = new System.Drawing.Point(513, 517);
            this.RecoveryAllBTN.Name = "RecoveryAllBTN";
            this.RecoveryAllBTN.Size = new System.Drawing.Size(177, 42);
            this.RecoveryAllBTN.TabIndex = 16;
            this.RecoveryAllBTN.Text = "Recovery All";
            this.RecoveryAllBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RecoveryAllBTN.UseVisualStyleBackColor = false;
            // 
            // BinGridView
            // 
            this.BinGridView.AllowUserToOrderColumns = true;
            this.BinGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BinGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BinGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BinGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BinGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BinGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.BinGridView.EnableHeadersVisualStyles = false;
            this.BinGridView.Location = new System.Drawing.Point(33, 159);
            this.BinGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BinGridView.Name = "BinGridView";
            this.BinGridView.ReadOnly = true;
            this.BinGridView.RowHeadersWidth = 62;
            this.BinGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BinGridView.Size = new System.Drawing.Size(657, 350);
            this.BinGridView.TabIndex = 17;
            this.BinGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BinGridView_CellClick);
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
            // Input_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 716);
            this.Controls.Add(this.tabControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BinGridView)).EndInit();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        protected ComboBox BinFilterCbb;
        private TextBox BinSearchingTB;
        private Button DeletedAllBTN;
        private Button RecoveryAllBTN;
        private DataGridView BinGridView;
        private StatusStrip statusStrip3;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private GroupBox groupBox5;
        private Button button3;
        private TrackBar trackBar1;
        private Panel panel7;
        private TextBox DeletedTimeTB;
        private TextBox CreatedTimeTB;
        private Label label12;
        private Label label18;
        private Button button7;
        private Panel panel6;
        private TextBox BinS_Textbox;
        private Label label16;
        private Button button6;
        private Label label17;
        private Panel panel5;
        private TextBox BinN_Textbox;
        private Label label14;
        private Button button5;
        private Button DltBTN;
        private Button RcvBTN;
        private TextBox CreatedDateTB;
        private TextBox DeletedDateTB;
    }
}
