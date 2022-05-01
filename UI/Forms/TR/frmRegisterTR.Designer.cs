namespace UI.Forms.TR
{
    partial class frmRegisterTR
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPaswordShow = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRepassowrd = new System.Windows.Forms.TextBox();
            this.lblRepassword = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblcCpyright = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblPasswordControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTitle.Location = new System.Drawing.Point(52, -50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 42);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Giriş Yap";
            // 
            // lblPaswordShow
            // 
            this.lblPaswordShow.AutoSize = true;
            this.lblPaswordShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaswordShow.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPaswordShow.Location = new System.Drawing.Point(378, 266);
            this.lblPaswordShow.Name = "lblPaswordShow";
            this.lblPaswordShow.Size = new System.Drawing.Size(133, 22);
            this.lblPaswordShow.TabIndex = 19;
            this.lblPaswordShow.Text = "Şifreyi Göster";
            this.lblPaswordShow.Visible = false;
            this.lblPaswordShow.Click += new System.EventHandler(this.lblPaswordShow_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(40, 291);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(472, 49);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPassword.Location = new System.Drawing.Point(40, 248);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 29);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Şifre";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(39, 184);
            this.txtUsername.MaxLength = 30;
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(472, 49);
            this.txtUsername.TabIndex = 16;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblUsername.Location = new System.Drawing.Point(39, 141);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(158, 29);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(39, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "Üye Ol";
            // 
            // txtRepassowrd
            // 
            this.txtRepassowrd.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRepassowrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRepassowrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRepassowrd.ForeColor = System.Drawing.Color.White;
            this.txtRepassowrd.Location = new System.Drawing.Point(39, 401);
            this.txtRepassowrd.MaxLength = 30;
            this.txtRepassowrd.Multiline = true;
            this.txtRepassowrd.Name = "txtRepassowrd";
            this.txtRepassowrd.PasswordChar = '*';
            this.txtRepassowrd.Size = new System.Drawing.Size(472, 49);
            this.txtRepassowrd.TabIndex = 21;
            this.txtRepassowrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRepassowrd.TextChanged += new System.EventHandler(this.txtRepassowrd_TextChanged);
            // 
            // lblRepassword
            // 
            this.lblRepassword.AutoSize = true;
            this.lblRepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRepassword.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblRepassword.Location = new System.Drawing.Point(38, 354);
            this.lblRepassword.Name = "lblRepassword";
            this.lblRepassword.Size = new System.Drawing.Size(159, 29);
            this.lblRepassword.TabIndex = 20;
            this.lblRepassword.Text = "Tekrar Şifre ";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmailAddress.ForeColor = System.Drawing.Color.White;
            this.txtEmailAddress.Location = new System.Drawing.Point(39, 506);
            this.txtEmailAddress.MaxLength = 30;
            this.txtEmailAddress.Multiline = true;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.PasswordChar = '*';
            this.txtEmailAddress.Size = new System.Drawing.Size(472, 49);
            this.txtEmailAddress.TabIndex = 23;
            this.txtEmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmailAddress.UseSystemPasswordChar = true;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailAddress.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblEmailAddress.Location = new System.Drawing.Point(39, 462);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(170, 29);
            this.lblEmailAddress.TabIndex = 22;
            this.lblEmailAddress.Text = "E-mail Adresi";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRegister.Location = new System.Drawing.Point(96, 616);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(372, 60);
            this.btnRegister.TabIndex = 24;
            this.btnRegister.Text = "Hesap Oluştur  ";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblcCpyright
            // 
            this.lblcCpyright.AutoSize = true;
            this.lblcCpyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcCpyright.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblcCpyright.Location = new System.Drawing.Point(353, 749);
            this.lblcCpyright.Name = "lblcCpyright";
            this.lblcCpyright.Size = new System.Drawing.Size(216, 22);
            this.lblcCpyright.TabIndex = 25;
            this.lblcCpyright.Text = "Made by EDK Software";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblClose.Location = new System.Drawing.Point(490, 41);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(38, 42);
            this.lblClose.TabIndex = 26;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblPasswordControl
            // 
            this.lblPasswordControl.AutoSize = true;
            this.lblPasswordControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordControl.ForeColor = System.Drawing.Color.Crimson;
            this.lblPasswordControl.Location = new System.Drawing.Point(282, 376);
            this.lblPasswordControl.Name = "lblPasswordControl";
            this.lblPasswordControl.Size = new System.Drawing.Size(154, 22);
            this.lblPasswordControl.TabIndex = 27;
            this.lblPasswordControl.Text = "Şifre uyuşmuyor";
            this.lblPasswordControl.Visible = false;
            // 
            // frmRegisterTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(581, 780);
            this.Controls.Add(this.lblPasswordControl);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblcCpyright);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.txtRepassowrd);
            this.Controls.Add(this.lblRepassword);
            this.Controls.Add(this.lblPaswordShow);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegisterTR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegisterTR";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRegisterTR_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmRegisterTR_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmRegisterTR_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitle;
        private Label lblPaswordShow;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label label1;
        private TextBox txtRepassowrd;
        private Label lblRepassword;
        private TextBox txtEmailAddress;
        private Label lblEmailAddress;
        private Button btnRegister;
        private Label lblcCpyright;
        private Label lblClose;
        private Label lblPasswordControl;
    }
}