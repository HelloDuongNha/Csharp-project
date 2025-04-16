namespace Part1
{
    partial class GUI_SignInForm
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
            this.SignInBtn = new System.Windows.Forms.Button();
            this.PwTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LoginPwWrn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginUsernameWrn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SeePWcheck = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SeePWcheck);
            this.groupBox1.Controls.Add(this.SignInBtn);
            this.groupBox1.Controls.Add(this.PwTxt);
            this.groupBox1.Controls.Add(this.UsernameTxt);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.LoginPwWrn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LoginUsernameWrn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(356, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log in";
            // 
            // SignInBtn
            // 
            this.SignInBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SignInBtn.Location = new System.Drawing.Point(217, 190);
            this.SignInBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(116, 30);
            this.SignInBtn.TabIndex = 5;
            this.SignInBtn.Text = "Sign in";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // PwTxt
            // 
            this.PwTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwTxt.Location = new System.Drawing.Point(99, 106);
            this.PwTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PwTxt.MaxLength = 40;
            this.PwTxt.Name = "PwTxt";
            this.PwTxt.PasswordChar = '*';
            this.PwTxt.Size = new System.Drawing.Size(189, 29);
            this.PwTxt.TabIndex = 4;
            this.PwTxt.TextChanged += new System.EventHandler(this.PwTxt_TextChanged);
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(99, 43);
            this.UsernameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(189, 29);
            this.UsernameTxt.TabIndex = 3;
            this.UsernameTxt.TextChanged += new System.EventHandler(this.UsernameTxt_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.Location = new System.Drawing.Point(15, 168);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(201, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Don\'t have an account? Sign up here!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginPwWrn
            // 
            this.LoginPwWrn.AutoSize = true;
            this.LoginPwWrn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.LoginPwWrn.Location = new System.Drawing.Point(96, 133);
            this.LoginPwWrn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginPwWrn.Name = "LoginPwWrn";
            this.LoginPwWrn.Size = new System.Drawing.Size(59, 13);
            this.LoginPwWrn.TabIndex = 1;
            this.LoginPwWrn.Text = "PwWrnLbl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // LoginUsernameWrn
            // 
            this.LoginUsernameWrn.AutoSize = true;
            this.LoginUsernameWrn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.LoginUsernameWrn.Location = new System.Drawing.Point(96, 70);
            this.LoginUsernameWrn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginUsernameWrn.Name = "LoginUsernameWrn";
            this.LoginUsernameWrn.Size = new System.Drawing.Size(73, 13);
            this.LoginUsernameWrn.TabIndex = 0;
            this.LoginUsernameWrn.Text = "NameWrnLbl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // SeePWcheck
            // 
            this.SeePWcheck.AutoSize = true;
            this.SeePWcheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SeePWcheck.Location = new System.Drawing.Point(293, 114);
            this.SeePWcheck.Name = "SeePWcheck";
            this.SeePWcheck.Size = new System.Drawing.Size(15, 14);
            this.SeePWcheck.TabIndex = 6;
            this.SeePWcheck.UseVisualStyleBackColor = true;
            this.SeePWcheck.CheckedChanged += new System.EventHandler(this.SeePWcheck_CheckedChanged);
            // 
            // GUI_SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 243);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GUI_SignInForm";
            this.Text = "Login_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PwTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Label LoginPwWrn;
        private System.Windows.Forms.Label LoginUsernameWrn;
        private System.Windows.Forms.CheckBox SeePWcheck;
    }
}