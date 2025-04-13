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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SignInBtn);
            this.groupBox1.Controls.Add(this.PwTxt);
            this.groupBox1.Controls.Add(this.UsernameTxt);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log in";
            // 
            // SignInBtn
            // 
            this.SignInBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SignInBtn.Location = new System.Drawing.Point(326, 292);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(174, 46);
            this.SignInBtn.TabIndex = 5;
            this.SignInBtn.Text = "Sign in";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // PwTxt
            // 
            this.PwTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwTxt.Location = new System.Drawing.Point(148, 163);
            this.PwTxt.MaxLength = 40;
            this.PwTxt.Name = "PwTxt";
            this.PwTxt.PasswordChar = '*';
            this.PwTxt.Size = new System.Drawing.Size(352, 39);
            this.PwTxt.TabIndex = 4;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(148, 66);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(352, 39);
            this.UsernameTxt.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.Location = new System.Drawing.Point(23, 259);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(292, 21);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Don\'t have an account? Sign up here!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.Location = new System.Drawing.Point(144, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "PwWrnLbl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label4.Location = new System.Drawing.Point(144, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "NameWrnLbl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // SignIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 374);
            this.Controls.Add(this.groupBox1);
            this.Name = "SignIn_Form";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}