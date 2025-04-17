namespace Part1
{
    partial class GUI_SignUpForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SeeCfPwCheck = new System.Windows.Forms.CheckBox();
            this.seePwCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CfPwTxt = new System.Windows.Forms.TextBox();
            this.PwTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.UserameTxt = new System.Windows.Forms.TextBox();
            this.CfPwWrn = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.PwWrn = new System.Windows.Forms.Label();
            this.EmailWrn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UsernameWrn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SeeCfPwCheck);
            this.groupBox1.Controls.Add(this.seePwCheck);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.CfPwTxt);
            this.groupBox1.Controls.Add(this.PwTxt);
            this.groupBox1.Controls.Add(this.EmailTxt);
            this.groupBox1.Controls.Add(this.UserameTxt);
            this.groupBox1.Controls.Add(this.CfPwWrn);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PwWrn);
            this.groupBox1.Controls.Add(this.EmailWrn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.UsernameWrn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(408, 335);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registation";
            // 
            // SeeCfPwCheck
            // 
            this.SeeCfPwCheck.AutoSize = true;
            this.SeeCfPwCheck.Location = new System.Drawing.Point(368, 205);
            this.SeeCfPwCheck.Name = "SeeCfPwCheck";
            this.SeeCfPwCheck.Size = new System.Drawing.Size(15, 14);
            this.SeeCfPwCheck.TabIndex = 7;
            this.SeeCfPwCheck.UseVisualStyleBackColor = true;
            this.SeeCfPwCheck.CheckedChanged += new System.EventHandler(this.SeeCfPwCheck_CheckedChanged);
            // 
            // seePwCheck
            // 
            this.seePwCheck.AutoSize = true;
            this.seePwCheck.Location = new System.Drawing.Point(368, 157);
            this.seePwCheck.Name = "seePwCheck";
            this.seePwCheck.Size = new System.Drawing.Size(15, 14);
            this.seePwCheck.TabIndex = 6;
            this.seePwCheck.UseVisualStyleBackColor = true;
            this.seePwCheck.CheckedChanged += new System.EventHandler(this.SeePwCheck_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(275, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // CfPwTxt
            // 
            this.CfPwTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CfPwTxt.Location = new System.Drawing.Point(144, 198);
            this.CfPwTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CfPwTxt.Name = "CfPwTxt";
            this.CfPwTxt.PasswordChar = '*';
            this.CfPwTxt.Size = new System.Drawing.Size(218, 29);
            this.CfPwTxt.TabIndex = 4;
            this.CfPwTxt.TextChanged += new System.EventHandler(this.CfPwTxt_TextChanged);
            // 
            // PwTxt
            // 
            this.PwTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwTxt.Location = new System.Drawing.Point(144, 148);
            this.PwTxt.Margin = new System.Windows.Forms.Padding(2);
            this.PwTxt.Name = "PwTxt";
            this.PwTxt.PasswordChar = '*';
            this.PwTxt.Size = new System.Drawing.Size(218, 29);
            this.PwTxt.TabIndex = 4;
            this.PwTxt.TextChanged += new System.EventHandler(this.PwTxt_TextChanged);
            // 
            // EmailTxt
            // 
            this.EmailTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.Location = new System.Drawing.Point(142, 98);
            this.EmailTxt.Margin = new System.Windows.Forms.Padding(2);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(236, 29);
            this.EmailTxt.TabIndex = 3;
            this.EmailTxt.TextChanged += new System.EventHandler(this.EmailTxt_TextChanged);
            // 
            // UserameTxt
            // 
            this.UserameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserameTxt.Location = new System.Drawing.Point(142, 47);
            this.UserameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.UserameTxt.Name = "UserameTxt";
            this.UserameTxt.Size = new System.Drawing.Size(236, 29);
            this.UserameTxt.TabIndex = 3;
            this.UserameTxt.TextChanged += new System.EventHandler(this.UserameTxt_TextChanged);
            // 
            // CfPwWrn
            // 
            this.CfPwWrn.AutoSize = true;
            this.CfPwWrn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CfPwWrn.Location = new System.Drawing.Point(143, 225);
            this.CfPwWrn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CfPwWrn.Name = "CfPwWrn";
            this.CfPwWrn.Size = new System.Drawing.Size(70, 13);
            this.CfPwWrn.TabIndex = 1;
            this.CfPwWrn.Text = "CfPwWrnLbl";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.Location = new System.Drawing.Point(9, 261);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(209, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an account? Sign in here!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Confirm Password";
            // 
            // PwWrn
            // 
            this.PwWrn.AutoSize = true;
            this.PwWrn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.PwWrn.Location = new System.Drawing.Point(143, 175);
            this.PwWrn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PwWrn.Name = "PwWrn";
            this.PwWrn.Size = new System.Drawing.Size(59, 13);
            this.PwWrn.TabIndex = 1;
            this.PwWrn.Text = "PwWrnLbl";
            // 
            // EmailWrn
            // 
            this.EmailWrn.AutoSize = true;
            this.EmailWrn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.EmailWrn.Location = new System.Drawing.Point(144, 125);
            this.EmailWrn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailWrn.Name = "EmailWrn";
            this.EmailWrn.Size = new System.Drawing.Size(71, 13);
            this.EmailWrn.TabIndex = 0;
            this.EmailWrn.Text = "EmailWrnLbl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email";
            // 
            // UsernameWrn
            // 
            this.UsernameWrn.AutoSize = true;
            this.UsernameWrn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.UsernameWrn.Location = new System.Drawing.Point(141, 75);
            this.UsernameWrn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameWrn.Name = "UsernameWrn";
            this.UsernameWrn.Size = new System.Drawing.Size(73, 13);
            this.UsernameWrn.TabIndex = 0;
            this.UsernameWrn.Text = "NameWrnLbl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // GUI_SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 349);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI_SignUpForm";
            this.Text = "SIGN UP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PwTxt;
        private System.Windows.Forms.TextBox UserameTxt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label PwWrn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UsernameWrn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CfPwTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label CfPwWrn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label EmailWrn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox SeeCfPwCheck;
        private System.Windows.Forms.CheckBox seePwCheck;
    }
}