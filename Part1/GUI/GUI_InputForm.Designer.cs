using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Part1
{
    partial class GUI_InputForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.SearchTB = new System.Windows.Forms.TextBox();
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
            this.searchWrnLbl2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BinSearchingTB = new System.Windows.Forms.TextBox();
            this.DeletedAllBTN = new System.Windows.Forms.Button();
            this.RecoveryAllBTN = new System.Windows.Forms.Button();
            this.BinGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.RBFullscreen = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.RBWindow = new System.Windows.Forms.RadioButton();
            this.panel16 = new System.Windows.Forms.Panel();
            this.Opacity = new System.Windows.Forms.TrackBar();
            this.label20 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Height = new System.Windows.Forms.NumericUpDown();
            this.Width = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RBdarkmodeOff = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.RBdarkmodeON = new System.Windows.Forms.RadioButton();
            this.SetDefaultBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.DateIn4 = new System.Windows.Forms.TextBox();
            this.TimeIn4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.UsernameIn4 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.EmailIn4 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.UpdateInfoBtn = new System.Windows.Forms.Button();
            this.ChangePwBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.DeleteAccBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.DeleteUserAcc = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.AccRecordTB = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.AccDateTB = new System.Windows.Forms.TextBox();
            this.AccTimeTB = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.AccNameTB = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.AccEmailTB = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.DeleteAllUserAcc = new System.Windows.Forms.Button();
            this.AccGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label31 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
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
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Opacity)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccGridView)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // encodeBTN
            // 
            this.encodeBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.encodeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encodeBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.encodeBTN.Location = new System.Drawing.Point(17, 212);
            this.encodeBTN.Margin = new System.Windows.Forms.Padding(2);
            this.encodeBTN.Name = "encodeBTN";
            this.encodeBTN.Size = new System.Drawing.Size(265, 29);
            this.encodeBTN.TabIndex = 2;
            this.encodeBTN.Text = "ENCODE";
            this.encodeBTN.UseVisualStyleBackColor = false;
            this.encodeBTN.Click += new System.EventHandler(this.encodeBTN_Click);
            // 
            // ResetBTN
            // 
            this.ResetBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ResetBTN.Location = new System.Drawing.Point(21, 330);
            this.ResetBTN.Margin = new System.Windows.Forms.Padding(2);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(71, 27);
            this.ResetBTN.TabIndex = 7;
            this.ResetBTN.Text = "Reset";
            this.ResetBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.Reset_Click);
            // 
            // DecreaseBTN
            // 
            this.DecreaseBTN.Location = new System.Drawing.Point(13, 24);
            this.DecreaseBTN.Margin = new System.Windows.Forms.Padding(2);
            this.DecreaseBTN.Name = "DecreaseBTN";
            this.DecreaseBTN.Size = new System.Drawing.Size(30, 33);
            this.DecreaseBTN.TabIndex = 7;
            this.DecreaseBTN.Text = "-";
            this.DecreaseBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DecreaseBTN.UseVisualStyleBackColor = true;
            this.DecreaseBTN.Click += new System.EventHandler(this.DecreaseBTN_Click);
            // 
            // IncreaseBTN
            // 
            this.IncreaseBTN.Location = new System.Drawing.Point(86, 24);
            this.IncreaseBTN.Margin = new System.Windows.Forms.Padding(2);
            this.IncreaseBTN.Name = "IncreaseBTN";
            this.IncreaseBTN.Size = new System.Drawing.Size(30, 33);
            this.IncreaseBTN.TabIndex = 7;
            this.IncreaseBTN.Text = "+";
            this.IncreaseBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IncreaseBTN.UseVisualStyleBackColor = true;
            this.IncreaseBTN.Click += new System.EventHandler(this.IncreaseBTN_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxN.Location = new System.Drawing.Point(47, 28);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(35, 29);
            this.textBoxN.TabIndex = 2;
            this.textBoxN.Text = "0";
            this.textBoxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxN.TextChanged += new System.EventHandler(this.textBoxN_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.Location = new System.Drawing.Point(2, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number N:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.Location = new System.Drawing.Point(2, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "String S:";
            // 
            // wrnLbl2
            // 
            this.wrnLbl2.AutoSize = true;
            this.wrnLbl2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.wrnLbl2.ForeColor = System.Drawing.Color.Green;
            this.wrnLbl2.Location = new System.Drawing.Point(15, 59);
            this.wrnLbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrnLbl2.Name = "wrnLbl2";
            this.wrnLbl2.Size = new System.Drawing.Size(50, 13);
            this.wrnLbl2.TabIndex = 3;
            this.wrnLbl2.Text = "✅ Valid.";
            // 
            // wrnLb1
            // 
            this.wrnLb1.AutoSize = true;
            this.wrnLb1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.wrnLb1.ForeColor = System.Drawing.Color.Red;
            this.wrnLb1.Location = new System.Drawing.Point(15, 53);
            this.wrnLb1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrnLb1.Name = "wrnLb1";
            this.wrnLb1.Size = new System.Drawing.Size(113, 13);
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
            this.groupBox1.Controls.Add(this.SearchTB);
            this.groupBox1.Controls.Add(this.DeleteBTN);
            this.groupBox1.Controls.Add(this.ResetBTN);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(421, 390);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT HISTORY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(19, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Search:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(333, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "filter by:";
            // 
            // searchWrnLbl
            // 
            this.searchWrnLbl.AutoSize = true;
            this.searchWrnLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.searchWrnLbl.ForeColor = System.Drawing.Color.Red;
            this.searchWrnLbl.Location = new System.Drawing.Point(25, 81);
            this.searchWrnLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchWrnLbl.Name = "searchWrnLbl";
            this.searchWrnLbl.Size = new System.Drawing.Size(88, 13);
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
            this.comboBox1.Location = new System.Drawing.Point(336, 45);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(69, 29);
            this.comboBox1.TabIndex = 13;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 370);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(94, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel1.Text = "Total Record: ";
            // 
            // SearchTB
            // 
            this.SearchTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SearchTB.Location = new System.Drawing.Point(21, 45);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(309, 29);
            this.SearchTB.TabIndex = 12;
            this.SearchTB.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteBTN.Location = new System.Drawing.Point(336, 330);
            this.DeleteBTN.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(71, 27);
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
            this.dataGridView.Location = new System.Drawing.Point(21, 98);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(385, 227);
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
            this.panel3.Location = new System.Drawing.Point(17, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 109);
            this.panel3.TabIndex = 10;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(135, 26);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Minimum = -25;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(112, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonOther);
            this.panel1.Controls.Add(this.radioButton25);
            this.panel1.Controls.Add(this.radioButton10);
            this.panel1.Controls.Add(this.radioButton0);
            this.panel1.Location = new System.Drawing.Point(92, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 26);
            this.panel1.TabIndex = 8;
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonOther.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.radioButtonOther.Location = new System.Drawing.Point(113, 3);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(53, 17);
            this.radioButtonOther.TabIndex = 0;
            this.radioButtonOther.Text = "other";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            // 
            // radioButton25
            // 
            this.radioButton25.AutoSize = true;
            this.radioButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton25.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.radioButton25.Location = new System.Drawing.Point(76, 3);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(37, 17);
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
            this.radioButton10.Location = new System.Drawing.Point(39, 3);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(37, 17);
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
            this.radioButton0.Location = new System.Drawing.Point(3, 3);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(31, 17);
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
            this.label1.Location = new System.Drawing.Point(5, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
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
            this.panel2.Location = new System.Drawing.Point(17, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 73);
            this.panel2.TabIndex = 9;
            // 
            // textBoxS
            // 
            this.textBoxS.AcceptsTab = true;
            this.textBoxS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxS.Location = new System.Drawing.Point(13, 25);
            this.textBoxS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxS.Multiline = true;
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(203, 23);
            this.textBoxS.TabIndex = 1;
            this.textBoxS.TextChanged += new System.EventHandler(this.textBoxS_TextChanged);
            // 
            // uppercaseBTN
            // 
            this.uppercaseBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uppercaseBTN.Location = new System.Drawing.Point(219, 21);
            this.uppercaseBTN.Margin = new System.Windows.Forms.Padding(2);
            this.uppercaseBTN.Name = "uppercaseBTN";
            this.uppercaseBTN.Size = new System.Drawing.Size(41, 28);
            this.uppercaseBTN.TabIndex = 2;
            this.uppercaseBTN.Text = "⇧";
            this.uppercaseBTN.UseVisualStyleBackColor = true;
            this.uppercaseBTN.Click += new System.EventHandler(this.UppercaseBTN_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(69, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.clearInput_Click);
            // 
            // CountLbl
            // 
            this.CountLbl.AutoSize = true;
            this.CountLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CountLbl.Location = new System.Drawing.Point(149, 6);
            this.CountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountLbl.Name = "CountLbl";
            this.CountLbl.Size = new System.Drawing.Size(74, 13);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(754, 414);
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
            this.groupBox3.Location = new System.Drawing.Point(449, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 138);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " INPUT REQUIREMENT FOR USER";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox3.Location = new System.Drawing.Point(169, 43);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 89);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "- Must be a number between -25 and 25.\r\n- Determines how much each letter shifts " +
    "in encoding.";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textBox2.Location = new System.Drawing.Point(6, 43);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 89);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "- Must be ALL capital letters (A-Z).\r\n- Maximum 40 characters.\r\n- No lowercase le" +
    "tters, numbers, or special characters.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(193, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Integer (N)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(51, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "String (S)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.encodeBTN);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(449, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 246);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INPUT AREA";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 444);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(754, 414);
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
            this.groupBox5.Location = new System.Drawing.Point(507, 15);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(230, 391);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Details (ID: ? )";
            // 
            // DltBTN
            // 
            this.DltBTN.BackColor = System.Drawing.Color.LightCoral;
            this.DltBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DltBTN.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.DltBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DltBTN.Location = new System.Drawing.Point(5, 350);
            this.DltBTN.Margin = new System.Windows.Forms.Padding(2);
            this.DltBTN.Name = "DltBTN";
            this.DltBTN.Size = new System.Drawing.Size(213, 32);
            this.DltBTN.TabIndex = 17;
            this.DltBTN.Text = "Delete";
            this.DltBTN.UseVisualStyleBackColor = false;
            this.DltBTN.Click += new System.EventHandler(this.BinDltBTN_Click);
            // 
            // RcvBTN
            // 
            this.RcvBTN.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.RcvBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RcvBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.RcvBTN.Location = new System.Drawing.Point(5, 313);
            this.RcvBTN.Margin = new System.Windows.Forms.Padding(2);
            this.RcvBTN.Name = "RcvBTN";
            this.RcvBTN.Size = new System.Drawing.Size(213, 33);
            this.RcvBTN.TabIndex = 18;
            this.RcvBTN.Text = "Recovery";
            this.RcvBTN.UseVisualStyleBackColor = false;
            this.RcvBTN.Click += new System.EventHandler(this.RcvBTN_Click);
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
            this.panel7.Location = new System.Drawing.Point(5, 157);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(217, 120);
            this.panel7.TabIndex = 10;
            // 
            // DeletedDateTB
            // 
            this.DeletedDateTB.AcceptsTab = true;
            this.DeletedDateTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.DeletedDateTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeletedDateTB.Location = new System.Drawing.Point(115, 75);
            this.DeletedDateTB.Margin = new System.Windows.Forms.Padding(2);
            this.DeletedDateTB.Multiline = true;
            this.DeletedDateTB.Name = "DeletedDateTB";
            this.DeletedDateTB.ReadOnly = true;
            this.DeletedDateTB.Size = new System.Drawing.Size(99, 23);
            this.DeletedDateTB.TabIndex = 1;
            // 
            // DeletedTimeTB
            // 
            this.DeletedTimeTB.AcceptsTab = true;
            this.DeletedTimeTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.DeletedTimeTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeletedTimeTB.Location = new System.Drawing.Point(13, 75);
            this.DeletedTimeTB.Margin = new System.Windows.Forms.Padding(2);
            this.DeletedTimeTB.Multiline = true;
            this.DeletedTimeTB.Name = "DeletedTimeTB";
            this.DeletedTimeTB.ReadOnly = true;
            this.DeletedTimeTB.Size = new System.Drawing.Size(99, 23);
            this.DeletedTimeTB.TabIndex = 1;
            // 
            // CreatedDateTB
            // 
            this.CreatedDateTB.AcceptsTab = true;
            this.CreatedDateTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.CreatedDateTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CreatedDateTB.Location = new System.Drawing.Point(115, 22);
            this.CreatedDateTB.Margin = new System.Windows.Forms.Padding(2);
            this.CreatedDateTB.Multiline = true;
            this.CreatedDateTB.Name = "CreatedDateTB";
            this.CreatedDateTB.ReadOnly = true;
            this.CreatedDateTB.Size = new System.Drawing.Size(99, 23);
            this.CreatedDateTB.TabIndex = 1;
            // 
            // CreatedTimeTB
            // 
            this.CreatedTimeTB.AcceptsTab = true;
            this.CreatedTimeTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.CreatedTimeTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CreatedTimeTB.Location = new System.Drawing.Point(13, 22);
            this.CreatedTimeTB.Margin = new System.Windows.Forms.Padding(2);
            this.CreatedTimeTB.Multiline = true;
            this.CreatedTimeTB.Name = "CreatedTimeTB";
            this.CreatedTimeTB.ReadOnly = true;
            this.CreatedTimeTB.Size = new System.Drawing.Size(99, 23);
            this.CreatedTimeTB.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label12.Location = new System.Drawing.Point(2, 55);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Deleted at";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label18.Location = new System.Drawing.Point(2, 2);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 19);
            this.label18.TabIndex = 4;
            this.label18.Text = "Encoded at";
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(-1000, -1000);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(41, 28);
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
            this.panel6.Location = new System.Drawing.Point(5, 36);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(217, 58);
            this.panel6.TabIndex = 10;
            // 
            // BinS_Textbox
            // 
            this.BinS_Textbox.AcceptsTab = true;
            this.BinS_Textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.BinS_Textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BinS_Textbox.Location = new System.Drawing.Point(13, 23);
            this.BinS_Textbox.Margin = new System.Windows.Forms.Padding(2);
            this.BinS_Textbox.Multiline = true;
            this.BinS_Textbox.Name = "BinS_Textbox";
            this.BinS_Textbox.ReadOnly = true;
            this.BinS_Textbox.Size = new System.Drawing.Size(203, 23);
            this.BinS_Textbox.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label16.Location = new System.Drawing.Point(2, 3);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 19);
            this.label16.TabIndex = 4;
            this.label16.Text = "String S:";
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(-1000, -1000);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 28);
            this.button6.TabIndex = 2;
            this.button6.Text = "⇧";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label17.Location = new System.Drawing.Point(149, 6);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Length: 0/40 ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BinN_Textbox);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Location = new System.Drawing.Point(5, 94);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 58);
            this.panel5.TabIndex = 10;
            // 
            // BinN_Textbox
            // 
            this.BinN_Textbox.AcceptsTab = true;
            this.BinN_Textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.BinN_Textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BinN_Textbox.Location = new System.Drawing.Point(13, 25);
            this.BinN_Textbox.Margin = new System.Windows.Forms.Padding(2);
            this.BinN_Textbox.Multiline = true;
            this.BinN_Textbox.Name = "BinN_Textbox";
            this.BinN_Textbox.ReadOnly = true;
            this.BinN_Textbox.Size = new System.Drawing.Size(203, 23);
            this.BinN_Textbox.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label14.Location = new System.Drawing.Point(2, 3);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Number N:";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(-1000, -1000);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 28);
            this.button5.TabIndex = 2;
            this.button5.Text = "⇧";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.searchWrnLbl2);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.BinSearchingTB);
            this.groupBox4.Controls.Add(this.DeletedAllBTN);
            this.groupBox4.Controls.Add(this.RecoveryAllBTN);
            this.groupBox4.Controls.Add(this.BinGridView);
            this.groupBox4.Controls.Add(this.statusStrip3);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(479, 390);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recycle Bin";
            // 
            // searchWrnLbl2
            // 
            this.searchWrnLbl2.AutoSize = true;
            this.searchWrnLbl2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.searchWrnLbl2.ForeColor = System.Drawing.Color.Red;
            this.searchWrnLbl2.Location = new System.Drawing.Point(19, 84);
            this.searchWrnLbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchWrnLbl2.Name = "searchWrnLbl2";
            this.searchWrnLbl2.Size = new System.Drawing.Size(88, 13);
            this.searchWrnLbl2.TabIndex = 23;
            this.searchWrnLbl2.Text = "                           ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(19, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Search:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(389, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
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
            this.comboBox2.Location = new System.Drawing.Point(392, 50);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(69, 29);
            this.comboBox2.TabIndex = 20;
            // 
            // BinSearchingTB
            // 
            this.BinSearchingTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BinSearchingTB.Location = new System.Drawing.Point(22, 51);
            this.BinSearchingTB.Name = "BinSearchingTB";
            this.BinSearchingTB.Size = new System.Drawing.Size(364, 29);
            this.BinSearchingTB.TabIndex = 19;
            this.BinSearchingTB.TextChanged += new System.EventHandler(this.BinSearchingTB_TextChanged);
            // 
            // DeletedAllBTN
            // 
            this.DeletedAllBTN.BackColor = System.Drawing.Color.LightCoral;
            this.DeletedAllBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletedAllBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DeletedAllBTN.Location = new System.Drawing.Point(22, 336);
            this.DeletedAllBTN.Margin = new System.Windows.Forms.Padding(2);
            this.DeletedAllBTN.Name = "DeletedAllBTN";
            this.DeletedAllBTN.Size = new System.Drawing.Size(104, 27);
            this.DeletedAllBTN.TabIndex = 15;
            this.DeletedAllBTN.Text = "Delete All";
            this.DeletedAllBTN.UseVisualStyleBackColor = false;
            this.DeletedAllBTN.Click += new System.EventHandler(this.DeletedAllBTN_Click);
            // 
            // RecoveryAllBTN
            // 
            this.RecoveryAllBTN.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.RecoveryAllBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecoveryAllBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.RecoveryAllBTN.Location = new System.Drawing.Point(342, 336);
            this.RecoveryAllBTN.Margin = new System.Windows.Forms.Padding(2);
            this.RecoveryAllBTN.Name = "RecoveryAllBTN";
            this.RecoveryAllBTN.Size = new System.Drawing.Size(118, 27);
            this.RecoveryAllBTN.TabIndex = 16;
            this.RecoveryAllBTN.Text = "Recovery All";
            this.RecoveryAllBTN.UseVisualStyleBackColor = false;
            this.RecoveryAllBTN.Click += new System.EventHandler(this.RecoveryAllBTN_Click);
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
            this.BinGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BinGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BinGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.BinGridView.EnableHeadersVisualStyles = false;
            this.BinGridView.Location = new System.Drawing.Point(22, 103);
            this.BinGridView.Name = "BinGridView";
            this.BinGridView.ReadOnly = true;
            this.BinGridView.RowHeadersWidth = 62;
            this.BinGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BinGridView.Size = new System.Drawing.Size(438, 227);
            this.BinGridView.TabIndex = 17;
            this.BinGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BinGridView_CellClick);
            // 
            // statusStrip3
            // 
            this.statusStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip3.Location = new System.Drawing.Point(3, 370);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip3.Size = new System.Drawing.Size(94, 22);
            this.statusStrip3.TabIndex = 18;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel2.Text = "Total Record: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(27, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(754, 414);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Setting";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox7.Controls.Add(this.panel10);
            this.groupBox7.Controls.Add(this.panel16);
            this.groupBox7.Controls.Add(this.panel9);
            this.groupBox7.Controls.Add(this.panel4);
            this.groupBox7.Controls.Add(this.SetDefaultBtn);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox7.Location = new System.Drawing.Point(15, 15);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(479, 390);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Setting";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.RBFullscreen);
            this.panel10.Controls.Add(this.label22);
            this.panel10.Controls.Add(this.RBWindow);
            this.panel10.Location = new System.Drawing.Point(16, 168);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(401, 65);
            this.panel10.TabIndex = 8;
            // 
            // RBFullscreen
            // 
            this.RBFullscreen.AutoSize = true;
            this.RBFullscreen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.RBFullscreen.Location = new System.Drawing.Point(157, 21);
            this.RBFullscreen.Margin = new System.Windows.Forms.Padding(2);
            this.RBFullscreen.Name = "RBFullscreen";
            this.RBFullscreen.Size = new System.Drawing.Size(99, 23);
            this.RBFullscreen.TabIndex = 3;
            this.RBFullscreen.TabStop = true;
            this.RBFullscreen.Text = "Full Screen";
            this.RBFullscreen.UseVisualStyleBackColor = true;
            this.RBFullscreen.CheckedChanged += new System.EventHandler(this.radioFullscreen_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(2, 21);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 19);
            this.label22.TabIndex = 1;
            this.label22.Text = "Mode:";
            // 
            // RBWindow
            // 
            this.RBWindow.AutoSize = true;
            this.RBWindow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.RBWindow.Location = new System.Drawing.Point(65, 21);
            this.RBWindow.Margin = new System.Windows.Forms.Padding(2);
            this.RBWindow.Name = "RBWindow";
            this.RBWindow.Size = new System.Drawing.Size(82, 23);
            this.RBWindow.TabIndex = 2;
            this.RBWindow.TabStop = true;
            this.RBWindow.Text = "Window";
            this.RBWindow.UseVisualStyleBackColor = true;
            this.RBWindow.CheckedChanged += new System.EventHandler(this.radioWindow_CheckedChanged);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.Opacity);
            this.panel16.Controls.Add(this.label20);
            this.panel16.Controls.Add(this.label32);
            this.panel16.Controls.Add(this.label26);
            this.panel16.Location = new System.Drawing.Point(16, 237);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(401, 65);
            this.panel16.TabIndex = 8;
            // 
            // Opacity
            // 
            this.Opacity.Location = new System.Drawing.Point(130, 18);
            this.Opacity.Margin = new System.Windows.Forms.Padding(2);
            this.Opacity.Maximum = 100;
            this.Opacity.Minimum = 50;
            this.Opacity.Name = "Opacity";
            this.Opacity.Size = new System.Drawing.Size(112, 45);
            this.Opacity.TabIndex = 10;
            this.Opacity.Value = 100;
            this.Opacity.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(2, 21);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 19);
            this.label20.TabIndex = 1;
            this.label20.Text = "Opacity:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label32.Location = new System.Drawing.Point(84, 25);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 19);
            this.label32.TabIndex = 7;
            this.label32.Text = "50%";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(246, 25);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 19);
            this.label26.TabIndex = 7;
            this.label26.Text = "100%";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.Height);
            this.panel9.Controls.Add(this.Width);
            this.panel9.Controls.Add(this.label13);
            this.panel9.Controls.Add(this.label21);
            this.panel9.Location = new System.Drawing.Point(16, 93);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(401, 65);
            this.panel9.TabIndex = 8;
            // 
            // Height
            // 
            this.Height.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Height.Location = new System.Drawing.Point(261, 16);
            this.Height.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Height.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(120, 25);
            this.Height.TabIndex = 3;
            this.Height.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Height.ValueChanged += new System.EventHandler(this.Height_ValueChanged);
            // 
            // Width
            // 
            this.Width.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Width.Location = new System.Drawing.Point(108, 16);
            this.Width.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Width.Minimum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(120, 25);
            this.Width.TabIndex = 3;
            this.Width.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.Width.ValueChanged += new System.EventHandler(this.Width_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(2, 21);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "Resolution:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(233, 15);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 28);
            this.label21.TabIndex = 7;
            this.label21.Text = "x";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.RBdarkmodeOff);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.RBdarkmodeON);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(16, 41);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 43);
            this.panel4.TabIndex = 4;
            // 
            // RBdarkmodeOff
            // 
            this.RBdarkmodeOff.AutoSize = true;
            this.RBdarkmodeOff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.RBdarkmodeOff.Location = new System.Drawing.Point(173, 12);
            this.RBdarkmodeOff.Margin = new System.Windows.Forms.Padding(2);
            this.RBdarkmodeOff.Name = "RBdarkmodeOff";
            this.RBdarkmodeOff.Size = new System.Drawing.Size(48, 23);
            this.RBdarkmodeOff.TabIndex = 3;
            this.RBdarkmodeOff.TabStop = true;
            this.RBdarkmodeOff.Text = "Off";
            this.RBdarkmodeOff.UseVisualStyleBackColor = true;
            this.RBdarkmodeOff.CheckedChanged += new System.EventHandler(this.RBdarkmodeOff_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(2, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Dark Mode:";
            // 
            // RBdarkmodeON
            // 
            this.RBdarkmodeON.AutoSize = true;
            this.RBdarkmodeON.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.RBdarkmodeON.Location = new System.Drawing.Point(119, 12);
            this.RBdarkmodeON.Margin = new System.Windows.Forms.Padding(2);
            this.RBdarkmodeON.Name = "RBdarkmodeON";
            this.RBdarkmodeON.Size = new System.Drawing.Size(46, 23);
            this.RBdarkmodeON.TabIndex = 2;
            this.RBdarkmodeON.TabStop = true;
            this.RBdarkmodeON.Text = "On";
            this.RBdarkmodeON.UseVisualStyleBackColor = true;
            this.RBdarkmodeON.CheckedChanged += new System.EventHandler(this.RBdarkmodeON_CheckedChanged);
            // 
            // SetDefaultBtn
            // 
            this.SetDefaultBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetDefaultBtn.Location = new System.Drawing.Point(16, 350);
            this.SetDefaultBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SetDefaultBtn.Name = "SetDefaultBtn";
            this.SetDefaultBtn.Size = new System.Drawing.Size(144, 31);
            this.SetDefaultBtn.TabIndex = 0;
            this.SetDefaultBtn.Text = "Reset to Default";
            this.SetDefaultBtn.UseVisualStyleBackColor = true;
            this.SetDefaultBtn.Click += new System.EventHandler(this.ResetSetting_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Controls.Add(this.panel8);
            this.groupBox6.Controls.Add(this.panel14);
            this.groupBox6.Controls.Add(this.panel15);
            this.groupBox6.Controls.Add(this.UpdateInfoBtn);
            this.groupBox6.Controls.Add(this.ChangePwBtn);
            this.groupBox6.Controls.Add(this.LogOutBtn);
            this.groupBox6.Controls.Add(this.DeleteAccBtn);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(507, 15);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(230, 391);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Account (id: )";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.DateIn4);
            this.panel8.Controls.Add(this.TimeIn4);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.button2);
            this.panel8.Location = new System.Drawing.Point(5, 153);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(217, 57);
            this.panel8.TabIndex = 11;
            // 
            // DateIn4
            // 
            this.DateIn4.AcceptsTab = true;
            this.DateIn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.DateIn4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DateIn4.Location = new System.Drawing.Point(115, 22);
            this.DateIn4.Margin = new System.Windows.Forms.Padding(2);
            this.DateIn4.Multiline = true;
            this.DateIn4.Name = "DateIn4";
            this.DateIn4.ReadOnly = true;
            this.DateIn4.Size = new System.Drawing.Size(99, 23);
            this.DateIn4.TabIndex = 1;
            // 
            // TimeIn4
            // 
            this.TimeIn4.AcceptsTab = true;
            this.TimeIn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.TimeIn4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TimeIn4.Location = new System.Drawing.Point(13, 22);
            this.TimeIn4.Margin = new System.Windows.Forms.Padding(2);
            this.TimeIn4.Multiline = true;
            this.TimeIn4.Name = "TimeIn4";
            this.TimeIn4.ReadOnly = true;
            this.TimeIn4.Size = new System.Drawing.Size(99, 23);
            this.TimeIn4.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label15.Location = new System.Drawing.Point(2, 2);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 19);
            this.label15.TabIndex = 4;
            this.label15.Text = "Created at";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(-1000, -1000);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "⇧";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.UsernameIn4);
            this.panel14.Controls.Add(this.label19);
            this.panel14.Controls.Add(this.button11);
            this.panel14.Location = new System.Drawing.Point(5, 32);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(217, 58);
            this.panel14.TabIndex = 12;
            // 
            // UsernameIn4
            // 
            this.UsernameIn4.AcceptsTab = true;
            this.UsernameIn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.UsernameIn4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UsernameIn4.Location = new System.Drawing.Point(13, 23);
            this.UsernameIn4.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameIn4.Multiline = true;
            this.UsernameIn4.Name = "UsernameIn4";
            this.UsernameIn4.ReadOnly = true;
            this.UsernameIn4.Size = new System.Drawing.Size(203, 23);
            this.UsernameIn4.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label19.Location = new System.Drawing.Point(2, 3);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 19);
            this.label19.TabIndex = 4;
            this.label19.Text = "Username:";
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Location = new System.Drawing.Point(-1000, -1000);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(41, 28);
            this.button11.TabIndex = 2;
            this.button11.Text = "⇧";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.EmailIn4);
            this.panel15.Controls.Add(this.label23);
            this.panel15.Controls.Add(this.button12);
            this.panel15.Location = new System.Drawing.Point(5, 90);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(217, 58);
            this.panel15.TabIndex = 13;
            // 
            // EmailIn4
            // 
            this.EmailIn4.AcceptsTab = true;
            this.EmailIn4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.EmailIn4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EmailIn4.Location = new System.Drawing.Point(13, 25);
            this.EmailIn4.Margin = new System.Windows.Forms.Padding(2);
            this.EmailIn4.Multiline = true;
            this.EmailIn4.Name = "EmailIn4";
            this.EmailIn4.ReadOnly = true;
            this.EmailIn4.Size = new System.Drawing.Size(201, 23);
            this.EmailIn4.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label23.Location = new System.Drawing.Point(2, 3);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 19);
            this.label23.TabIndex = 4;
            this.label23.Text = "Email:";
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Location = new System.Drawing.Point(-1000, -1000);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(41, 28);
            this.button12.TabIndex = 2;
            this.button12.Text = "⇧";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // UpdateInfoBtn
            // 
            this.UpdateInfoBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateInfoBtn.Location = new System.Drawing.Point(11, 234);
            this.UpdateInfoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateInfoBtn.Name = "UpdateInfoBtn";
            this.UpdateInfoBtn.Size = new System.Drawing.Size(203, 32);
            this.UpdateInfoBtn.TabIndex = 0;
            this.UpdateInfoBtn.Text = "Update Information";
            this.UpdateInfoBtn.UseVisualStyleBackColor = true;
            this.UpdateInfoBtn.Click += new System.EventHandler(this.UpdateAccInfo_Click);
            // 
            // ChangePwBtn
            // 
            this.ChangePwBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePwBtn.Location = new System.Drawing.Point(11, 270);
            this.ChangePwBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePwBtn.Name = "ChangePwBtn";
            this.ChangePwBtn.Size = new System.Drawing.Size(203, 32);
            this.ChangePwBtn.TabIndex = 0;
            this.ChangePwBtn.Text = "Change Password";
            this.ChangePwBtn.UseVisualStyleBackColor = true;
            this.ChangePwBtn.Click += new System.EventHandler(this.ChangePw_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.Location = new System.Drawing.Point(11, 307);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(203, 31);
            this.LogOutBtn.TabIndex = 0;
            this.LogOutBtn.Text = "Log out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // DeleteAccBtn
            // 
            this.DeleteAccBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAccBtn.Location = new System.Drawing.Point(11, 341);
            this.DeleteAccBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteAccBtn.Name = "DeleteAccBtn";
            this.DeleteAccBtn.Size = new System.Drawing.Size(203, 31);
            this.DeleteAccBtn.TabIndex = 0;
            this.DeleteAccBtn.Text = "Delete Account";
            this.DeleteAccBtn.UseVisualStyleBackColor = true;
            this.DeleteAccBtn.Click += new System.EventHandler(this.DeleteAcc_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(754, 414);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Admin";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox8.Controls.Add(this.DeleteUserAcc);
            this.groupBox8.Controls.Add(this.panel17);
            this.groupBox8.Controls.Add(this.panel11);
            this.groupBox8.Controls.Add(this.panel12);
            this.groupBox8.Controls.Add(this.panel13);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(507, 15);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(230, 391);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Account (ID: ? )";
            // 
            // DeleteUserAcc
            // 
            this.DeleteUserAcc.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteUserAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteUserAcc.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.DeleteUserAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteUserAcc.Location = new System.Drawing.Point(5, 350);
            this.DeleteUserAcc.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteUserAcc.Name = "DeleteUserAcc";
            this.DeleteUserAcc.Size = new System.Drawing.Size(213, 32);
            this.DeleteUserAcc.TabIndex = 17;
            this.DeleteUserAcc.Text = "Delete";
            this.DeleteUserAcc.UseVisualStyleBackColor = false;
            this.DeleteUserAcc.Click += new System.EventHandler(this.DeleteUserAcc_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.AccRecordTB);
            this.panel17.Controls.Add(this.label33);
            this.panel17.Controls.Add(this.button13);
            this.panel17.Location = new System.Drawing.Point(5, 230);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(217, 32);
            this.panel17.TabIndex = 10;
            // 
            // AccRecordTB
            // 
            this.AccRecordTB.AcceptsTab = true;
            this.AccRecordTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.AccRecordTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AccRecordTB.Location = new System.Drawing.Point(114, 2);
            this.AccRecordTB.Margin = new System.Windows.Forms.Padding(2);
            this.AccRecordTB.Multiline = true;
            this.AccRecordTB.Name = "AccRecordTB";
            this.AccRecordTB.ReadOnly = true;
            this.AccRecordTB.Size = new System.Drawing.Size(99, 23);
            this.AccRecordTB.TabIndex = 1;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label33.Location = new System.Drawing.Point(2, 2);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(100, 19);
            this.label33.TabIndex = 4;
            this.label33.Text = "Total Records";
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.Location = new System.Drawing.Point(-1000, -1000);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(41, 28);
            this.button13.TabIndex = 2;
            this.button13.Text = "⇧";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.AccDateTB);
            this.panel11.Controls.Add(this.AccTimeTB);
            this.panel11.Controls.Add(this.label24);
            this.panel11.Controls.Add(this.button4);
            this.panel11.Location = new System.Drawing.Point(5, 157);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(217, 57);
            this.panel11.TabIndex = 10;
            // 
            // AccDateTB
            // 
            this.AccDateTB.AcceptsTab = true;
            this.AccDateTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.AccDateTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AccDateTB.Location = new System.Drawing.Point(115, 22);
            this.AccDateTB.Margin = new System.Windows.Forms.Padding(2);
            this.AccDateTB.Multiline = true;
            this.AccDateTB.Name = "AccDateTB";
            this.AccDateTB.ReadOnly = true;
            this.AccDateTB.Size = new System.Drawing.Size(99, 23);
            this.AccDateTB.TabIndex = 1;
            // 
            // AccTimeTB
            // 
            this.AccTimeTB.AcceptsTab = true;
            this.AccTimeTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.AccTimeTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AccTimeTB.Location = new System.Drawing.Point(13, 22);
            this.AccTimeTB.Margin = new System.Windows.Forms.Padding(2);
            this.AccTimeTB.Multiline = true;
            this.AccTimeTB.Name = "AccTimeTB";
            this.AccTimeTB.ReadOnly = true;
            this.AccTimeTB.Size = new System.Drawing.Size(99, 23);
            this.AccTimeTB.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label24.Location = new System.Drawing.Point(2, 2);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 19);
            this.label24.TabIndex = 4;
            this.label24.Text = "Created at";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(-1000, -1000);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 28);
            this.button4.TabIndex = 2;
            this.button4.Text = "⇧";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.AccNameTB);
            this.panel12.Controls.Add(this.label25);
            this.panel12.Controls.Add(this.button8);
            this.panel12.Location = new System.Drawing.Point(5, 36);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(217, 58);
            this.panel12.TabIndex = 10;
            // 
            // AccNameTB
            // 
            this.AccNameTB.AcceptsTab = true;
            this.AccNameTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.AccNameTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AccNameTB.Location = new System.Drawing.Point(13, 23);
            this.AccNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.AccNameTB.Multiline = true;
            this.AccNameTB.Name = "AccNameTB";
            this.AccNameTB.ReadOnly = true;
            this.AccNameTB.Size = new System.Drawing.Size(203, 23);
            this.AccNameTB.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label25.Location = new System.Drawing.Point(2, 3);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 19);
            this.label25.TabIndex = 4;
            this.label25.Text = "Username:";
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Location = new System.Drawing.Point(-1000, -1000);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(41, 28);
            this.button8.TabIndex = 2;
            this.button8.Text = "⇧";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.AccEmailTB);
            this.panel13.Controls.Add(this.label27);
            this.panel13.Controls.Add(this.button9);
            this.panel13.Location = new System.Drawing.Point(5, 94);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(217, 58);
            this.panel13.TabIndex = 10;
            // 
            // AccEmailTB
            // 
            this.AccEmailTB.AcceptsTab = true;
            this.AccEmailTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.AccEmailTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AccEmailTB.Location = new System.Drawing.Point(13, 25);
            this.AccEmailTB.Margin = new System.Windows.Forms.Padding(2);
            this.AccEmailTB.Multiline = true;
            this.AccEmailTB.Name = "AccEmailTB";
            this.AccEmailTB.ReadOnly = true;
            this.AccEmailTB.Size = new System.Drawing.Size(203, 23);
            this.AccEmailTB.TabIndex = 1;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label27.Location = new System.Drawing.Point(2, 3);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(49, 19);
            this.label27.TabIndex = 4;
            this.label27.Text = "Email:";
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Location = new System.Drawing.Point(-1000, -1000);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(41, 28);
            this.button9.TabIndex = 2;
            this.button9.Text = "⇧";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox9.Controls.Add(this.label28);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Controls.Add(this.label30);
            this.groupBox9.Controls.Add(this.comboBox4);
            this.groupBox9.Controls.Add(this.textBox11);
            this.groupBox9.Controls.Add(this.DeleteAllUserAcc);
            this.groupBox9.Controls.Add(this.AccGridView);
            this.groupBox9.Controls.Add(this.statusStrip2);
            this.groupBox9.Controls.Add(this.label31);
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(15, 15);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox9.Size = new System.Drawing.Size(479, 390);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Account List";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(19, 84);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 13);
            this.label28.TabIndex = 23;
            this.label28.Text = "                           ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label29.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label29.Location = new System.Drawing.Point(19, 35);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(44, 13);
            this.label29.TabIndex = 22;
            this.label29.Text = "Search:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label30.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label30.Location = new System.Drawing.Point(389, 35);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 13);
            this.label30.TabIndex = 21;
            this.label30.Text = "filter by:";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "ID",
            "S",
            "N"});
            this.comboBox4.Location = new System.Drawing.Point(392, 50);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(69, 29);
            this.comboBox4.TabIndex = 20;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.textBox11.Location = new System.Drawing.Point(22, 51);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(364, 29);
            this.textBox11.TabIndex = 19;
            // 
            // DeleteAllUserAcc
            // 
            this.DeleteAllUserAcc.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteAllUserAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteAllUserAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteAllUserAcc.Location = new System.Drawing.Point(22, 336);
            this.DeleteAllUserAcc.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteAllUserAcc.Name = "DeleteAllUserAcc";
            this.DeleteAllUserAcc.Size = new System.Drawing.Size(104, 27);
            this.DeleteAllUserAcc.TabIndex = 15;
            this.DeleteAllUserAcc.Text = "Delete All";
            this.DeleteAllUserAcc.UseVisualStyleBackColor = false;
            this.DeleteAllUserAcc.Click += new System.EventHandler(this.DeleteAllUserAcc_Click);
            // 
            // AccGridView
            // 
            this.AccGridView.AllowUserToOrderColumns = true;
            this.AccGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AccGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AccGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AccGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.AccGridView.EnableHeadersVisualStyles = false;
            this.AccGridView.Location = new System.Drawing.Point(22, 103);
            this.AccGridView.Name = "AccGridView";
            this.AccGridView.ReadOnly = true;
            this.AccGridView.RowHeadersWidth = 62;
            this.AccGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccGridView.Size = new System.Drawing.Size(438, 227);
            this.AccGridView.TabIndex = 17;
            this.AccGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccGridView_CellClick);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3});
            this.statusStrip2.Location = new System.Drawing.Point(3, 370);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip2.Size = new System.Drawing.Size(94, 22);
            this.statusStrip2.TabIndex = 18;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel3.Text = "Total Record: ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label31.Location = new System.Drawing.Point(27, 36);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(0, 21);
            this.label31.TabIndex = 1;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // GUI_InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Name = "GUI_InputForm";
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
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Opacity)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccGridView)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
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
        private TextBox SearchTB;
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
        private Label searchWrnLbl2;
        private Label label10;
        private Label label9;
        protected ComboBox comboBox2;
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
        private TabPage tabPage2;
        private Button LogOutBtn;
        private Label label11;
        private Button ChangePwBtn;
        private Button DeleteAccBtn;
        private RadioButton RBdarkmodeON;
        private GroupBox groupBox6;
        private Panel panel4;
        private RadioButton RBdarkmodeOff;
        private GroupBox groupBox7;
        private Button UpdateInfoBtn;
        private Panel panel9;
        private Label label13;
        private Label label21;
        private Button SetDefaultBtn;
        private Panel panel10;
        private Label label22;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private TabPage tabPage4;
        private GroupBox groupBox8;
        private Button DeleteUserAcc;
        private Panel panel11;
        private Label label24;
        private Button button4;
        private Panel panel12;
        private TextBox AccNameTB;
        private Label label25;
        private Button button8;
        private Panel panel13;
        private TextBox AccEmailTB;
        private Label label27;
        private Button button9;
        private GroupBox groupBox9;
        private Label label28;
        private Label label29;
        private Label label30;
        protected ComboBox comboBox4;
        private TextBox textBox11;
        private Button DeleteAllUserAcc;
        private DataGridView AccGridView;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private Label label31;
        private Label label15;
        private Button button2;
        private Panel panel14;
        private Label label19;
        private Button button11;
        private Panel panel15;
        private Label label23;
        private Button button12;
        public TextBox UsernameIn4;
        public TextBox EmailIn4;
        private RadioButton RBFullscreen;
        private RadioButton RBWindow;
        private Panel panel16;
        private Label label20;
        private Label label26;
        public NumericUpDown Height;
        public NumericUpDown Width;
        private TrackBar Opacity;
        private Label label32;
        public TextBox AccDateTB;
        public TextBox AccTimeTB;
        public TextBox DateIn4;
        public TextBox TimeIn4;
        public Panel panel8;
        private Panel panel17;
        public TextBox AccRecordTB;
        private Label label33;
        private Button button13;
        private TabControl tabControl1;
    }
}
