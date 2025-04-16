namespace Part1.GUI
{
    partial class GUI_UpdateAccInfoForm
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
            this.TBUpdateUsername = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.TBUpdateEmail = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.UpdateInfoBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.UpdateInfoBtn);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(11, 11);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(287, 198);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Account (id: )";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.TBUpdateUsername);
            this.panel14.Controls.Add(this.label19);
            this.panel14.Controls.Add(this.button11);
            this.panel14.Location = new System.Drawing.Point(5, 32);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(277, 58);
            this.panel14.TabIndex = 12;
            // 
            // TBUpdateUsername
            // 
            this.TBUpdateUsername.AcceptsTab = true;
            this.TBUpdateUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.TBUpdateUsername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TBUpdateUsername.Location = new System.Drawing.Point(13, 23);
            this.TBUpdateUsername.Margin = new System.Windows.Forms.Padding(2);
            this.TBUpdateUsername.Multiline = true;
            this.TBUpdateUsername.Name = "TBUpdateUsername";
            this.TBUpdateUsername.Size = new System.Drawing.Size(203, 23);
            this.TBUpdateUsername.TabIndex = 1;
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
            this.panel15.Controls.Add(this.TBUpdateEmail);
            this.panel15.Controls.Add(this.label23);
            this.panel15.Controls.Add(this.button12);
            this.panel15.Location = new System.Drawing.Point(5, 96);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(277, 58);
            this.panel15.TabIndex = 13;
            // 
            // TBUpdateEmail
            // 
            this.TBUpdateEmail.AcceptsTab = true;
            this.TBUpdateEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.TBUpdateEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TBUpdateEmail.Location = new System.Drawing.Point(13, 25);
            this.TBUpdateEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TBUpdateEmail.Multiline = true;
            this.TBUpdateEmail.Name = "TBUpdateEmail";
            this.TBUpdateEmail.Size = new System.Drawing.Size(203, 23);
            this.TBUpdateEmail.TabIndex = 1;
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
            this.UpdateInfoBtn.Location = new System.Drawing.Point(91, 164);
            this.UpdateInfoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateInfoBtn.Name = "UpdateInfoBtn";
            this.UpdateInfoBtn.Size = new System.Drawing.Size(191, 32);
            this.UpdateInfoBtn.TabIndex = 0;
            this.UpdateInfoBtn.Text = "Save";
            this.UpdateInfoBtn.UseVisualStyleBackColor = true;
            this.UpdateInfoBtn.Click += new System.EventHandler(this.UpdateInfoBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GUI_UpdateAccInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 211);
            this.Controls.Add(this.groupBox6);
            this.Name = "GUI_UpdateAccInfoForm";
            this.Text = "GUI_UpdateAccInfoForm";
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
        public System.Windows.Forms.TextBox TBUpdateUsername;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel15;
        public System.Windows.Forms.TextBox TBUpdateEmail;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button UpdateInfoBtn;
        private System.Windows.Forms.Button button1;
    }
}