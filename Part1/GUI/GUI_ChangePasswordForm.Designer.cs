namespace Part1.GUI
{
    partial class GUI_ChangePasswordForm
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TBOldPassword = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.TBConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBNewPassword = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.UpdateInfoBtn = new System.Windows.Forms.Button();
            this.oldPwWrn = new System.Windows.Forms.Label();
            this.NewPwWrn = new System.Windows.Forms.Label();
            this.CFNewPwWrn = new System.Windows.Forms.Label();
            this.SeeOldPwCheck = new System.Windows.Forms.CheckBox();
            this.SeeNewPwCheck = new System.Windows.Forms.CheckBox();
            this.SeeConfirmPwCheck = new System.Windows.Forms.CheckBox();
            this.groupBox6.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Controls.Add(this.panel14);
            this.groupBox6.Controls.Add(this.panel15);
            this.groupBox6.Controls.Add(this.CancelBTN);
            this.groupBox6.Controls.Add(this.UpdateInfoBtn);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(16, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(430, 440);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Account (id: )";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.SeeOldPwCheck);
            this.panel14.Controls.Add(this.oldPwWrn);
            this.panel14.Controls.Add(this.linkLabel1);
            this.panel14.Controls.Add(this.TBOldPassword);
            this.panel14.Controls.Add(this.label19);
            this.panel14.Controls.Add(this.button11);
            this.panel14.Location = new System.Drawing.Point(8, 49);
            this.panel14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(414, 117);
            this.panel14.TabIndex = 12;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.Location = new System.Drawing.Point(267, 71);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "forgot password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPW_LinkClicked);
            // 
            // TBOldPassword
            // 
            this.TBOldPassword.AcceptsTab = true;
            this.TBOldPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.TBOldPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TBOldPassword.Location = new System.Drawing.Point(20, 35);
            this.TBOldPassword.Multiline = true;
            this.TBOldPassword.Name = "TBOldPassword";
            this.TBOldPassword.PasswordChar = '*';
            this.TBOldPassword.Size = new System.Drawing.Size(354, 33);
            this.TBOldPassword.TabIndex = 1;
            this.TBOldPassword.TextChanged += new System.EventHandler(this.TBOldPassword_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label19.Location = new System.Drawing.Point(3, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 19);
            this.label19.TabIndex = 4;
            this.label19.Text = "Current Password:";
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Location = new System.Drawing.Point(-1500, -1538);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(62, 43);
            this.button11.TabIndex = 2;
            this.button11.Text = "⇧";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.SeeConfirmPwCheck);
            this.panel15.Controls.Add(this.SeeNewPwCheck);
            this.panel15.Controls.Add(this.CFNewPwWrn);
            this.panel15.Controls.Add(this.NewPwWrn);
            this.panel15.Controls.Add(this.TBConfirmPassword);
            this.panel15.Controls.Add(this.label1);
            this.panel15.Controls.Add(this.TBNewPassword);
            this.panel15.Controls.Add(this.label23);
            this.panel15.Controls.Add(this.button12);
            this.panel15.Location = new System.Drawing.Point(6, 175);
            this.panel15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(416, 198);
            this.panel15.TabIndex = 13;
            // 
            // TBConfirmPassword
            // 
            this.TBConfirmPassword.AcceptsTab = true;
            this.TBConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.TBConfirmPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TBConfirmPassword.Location = new System.Drawing.Point(21, 135);
            this.TBConfirmPassword.Multiline = true;
            this.TBConfirmPassword.Name = "TBConfirmPassword";
            this.TBConfirmPassword.PasswordChar = '*';
            this.TBConfirmPassword.Size = new System.Drawing.Size(355, 33);
            this.TBConfirmPassword.TabIndex = 1;
            this.TBConfirmPassword.TextChanged += new System.EventHandler(this.TBConfirmPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(4, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Confirm new Password:";
            // 
            // TBNewPassword
            // 
            this.TBNewPassword.AcceptsTab = true;
            this.TBNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.TBNewPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TBNewPassword.Location = new System.Drawing.Point(20, 38);
            this.TBNewPassword.Multiline = true;
            this.TBNewPassword.Name = "TBNewPassword";
            this.TBNewPassword.PasswordChar = '*';
            this.TBNewPassword.Size = new System.Drawing.Size(356, 33);
            this.TBNewPassword.TabIndex = 1;
            this.TBNewPassword.TextChanged += new System.EventHandler(this.TBNewPassword_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label23.Location = new System.Drawing.Point(3, 5);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(111, 19);
            this.label23.TabIndex = 4;
            this.label23.Text = "New Password:";
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Location = new System.Drawing.Point(-1500, -1538);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(62, 43);
            this.button12.TabIndex = 2;
            this.button12.Text = "⇧";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // CancelBTN
            // 
            this.CancelBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBTN.Location = new System.Drawing.Point(6, 382);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(123, 49);
            this.CancelBTN.TabIndex = 0;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // UpdateInfoBtn
            // 
            this.UpdateInfoBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateInfoBtn.Location = new System.Drawing.Point(135, 382);
            this.UpdateInfoBtn.Name = "UpdateInfoBtn";
            this.UpdateInfoBtn.Size = new System.Drawing.Size(286, 49);
            this.UpdateInfoBtn.TabIndex = 0;
            this.UpdateInfoBtn.Text = "Save";
            this.UpdateInfoBtn.UseVisualStyleBackColor = true;
            this.UpdateInfoBtn.Click += new System.EventHandler(this.UpdateInfoBtn_Click);
            // 
            // oldPwWrn
            // 
            this.oldPwWrn.AutoSize = true;
            this.oldPwWrn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.oldPwWrn.Location = new System.Drawing.Point(17, 71);
            this.oldPwWrn.Name = "oldPwWrn";
            this.oldPwWrn.Size = new System.Drawing.Size(38, 13);
            this.oldPwWrn.TabIndex = 6;
            this.oldPwWrn.Text = "label2";
            // 
            // NewPwWrn
            // 
            this.NewPwWrn.AutoSize = true;
            this.NewPwWrn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.NewPwWrn.Location = new System.Drawing.Point(19, 74);
            this.NewPwWrn.Name = "NewPwWrn";
            this.NewPwWrn.Size = new System.Drawing.Size(38, 13);
            this.NewPwWrn.TabIndex = 6;
            this.NewPwWrn.Text = "label2";
            // 
            // CFNewPwWrn
            // 
            this.CFNewPwWrn.AutoSize = true;
            this.CFNewPwWrn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CFNewPwWrn.Location = new System.Drawing.Point(19, 171);
            this.CFNewPwWrn.Name = "CFNewPwWrn";
            this.CFNewPwWrn.Size = new System.Drawing.Size(38, 13);
            this.CFNewPwWrn.TabIndex = 6;
            this.CFNewPwWrn.Text = "label2";
            // 
            // SeeOldPwCheck
            // 
            this.SeeOldPwCheck.AutoSize = true;
            this.SeeOldPwCheck.Location = new System.Drawing.Point(380, 44);
            this.SeeOldPwCheck.Name = "SeeOldPwCheck";
            this.SeeOldPwCheck.Size = new System.Drawing.Size(15, 14);
            this.SeeOldPwCheck.TabIndex = 7;
            this.SeeOldPwCheck.UseVisualStyleBackColor = true;
            this.SeeOldPwCheck.CheckedChanged += new System.EventHandler(this.SeeOldPwCheck_CheckedChanged);
            // 
            // SeeNewPwCheck
            // 
            this.SeeNewPwCheck.AutoSize = true;
            this.SeeNewPwCheck.Location = new System.Drawing.Point(382, 49);
            this.SeeNewPwCheck.Name = "SeeNewPwCheck";
            this.SeeNewPwCheck.Size = new System.Drawing.Size(15, 14);
            this.SeeNewPwCheck.TabIndex = 7;
            this.SeeNewPwCheck.UseVisualStyleBackColor = true;
            this.SeeNewPwCheck.CheckedChanged += new System.EventHandler(this.SeeNewPwCheck_CheckedChanged);
            // 
            // SeeConfirmPwCheck
            // 
            this.SeeConfirmPwCheck.AutoSize = true;
            this.SeeConfirmPwCheck.Location = new System.Drawing.Point(382, 146);
            this.SeeConfirmPwCheck.Name = "SeeConfirmPwCheck";
            this.SeeConfirmPwCheck.Size = new System.Drawing.Size(15, 14);
            this.SeeConfirmPwCheck.TabIndex = 7;
            this.SeeConfirmPwCheck.UseVisualStyleBackColor = true;
            this.SeeConfirmPwCheck.CheckedChanged += new System.EventHandler(this.SeeConfirmPwCheck_CheckedChanged);
            // 
            // GUI_ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 469);
            this.Controls.Add(this.groupBox6);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_ChangePasswordForm";
            this.Text = "GUI_ChangePasswordForm";
            this.groupBox6.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel14;
        public System.Windows.Forms.TextBox TBOldPassword;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel15;
        public System.Windows.Forms.TextBox TBNewPassword;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button UpdateInfoBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.TextBox TBConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label oldPwWrn;
        private System.Windows.Forms.Label CFNewPwWrn;
        private System.Windows.Forms.Label NewPwWrn;
        private System.Windows.Forms.CheckBox SeeOldPwCheck;
        private System.Windows.Forms.CheckBox SeeConfirmPwCheck;
        private System.Windows.Forms.CheckBox SeeNewPwCheck;
    }
}