namespace UI.Forms.TR
{
    partial class frmLoginScreenTR
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbRememberMe = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblcCpyright = new System.Windows.Forms.Label();
            this.lblPaswordShow = new System.Windows.Forms.Label();
            this.linklblSendEmail = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTitle.Location = new System.Drawing.Point(52, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Giriş Yap";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblUsername.Location = new System.Drawing.Point(52, 145);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(158, 29);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Kullanıcı Adı";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(52, 188);
            this.txtUsername.MaxLength = 30;
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(472, 49);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(52, 295);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(472, 49);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPassword.Location = new System.Drawing.Point(52, 252);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 29);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Şifre";
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.BackColor = System.Drawing.Color.Transparent;
            this.cbRememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRememberMe.ForeColor = System.Drawing.Color.Cornsilk;
            this.cbRememberMe.Location = new System.Drawing.Point(353, 350);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Padding = new System.Windows.Forms.Padding(5, 2, 10, 2);
            this.cbRememberMe.Size = new System.Drawing.Size(170, 37);
            this.cbRememberMe.TabIndex = 5;
            this.cbRememberMe.Text = "Beni Hatırla";
            this.cbRememberMe.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnLogin.Location = new System.Drawing.Point(88, 411);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(372, 63);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRegister.Location = new System.Drawing.Point(88, 484);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(372, 60);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Hesap Oluştur  ";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblClose.Location = new System.Drawing.Point(520, 23);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(38, 42);
            this.lblClose.TabIndex = 8;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnglish.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblEnglish.Location = new System.Drawing.Point(12, 603);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(76, 22);
            this.lblEnglish.TabIndex = 9;
            this.lblEnglish.Text = "English";
            this.lblEnglish.Click += new System.EventHandler(this.lblEnglish_Click);
            // 
            // lblcCpyright
            // 
            this.lblcCpyright.AutoSize = true;
            this.lblcCpyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcCpyright.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblcCpyright.Location = new System.Drawing.Point(353, 605);
            this.lblcCpyright.Name = "lblcCpyright";
            this.lblcCpyright.Size = new System.Drawing.Size(216, 22);
            this.lblcCpyright.TabIndex = 10;
            this.lblcCpyright.Text = "Made by EDK Software";
            // 
            // lblPaswordShow
            // 
            this.lblPaswordShow.AutoSize = true;
            this.lblPaswordShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaswordShow.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPaswordShow.Location = new System.Drawing.Point(391, 270);
            this.lblPaswordShow.Name = "lblPaswordShow";
            this.lblPaswordShow.Size = new System.Drawing.Size(133, 22);
            this.lblPaswordShow.TabIndex = 12;
            this.lblPaswordShow.Text = "Şifreyi Göster";
            this.lblPaswordShow.Visible = false;
            this.lblPaswordShow.Click += new System.EventHandler(this.lblPaswordShow_Click);
            // 
            // linklblSendEmail
            // 
            this.linklblSendEmail.ActiveLinkColor = System.Drawing.SystemColors.WindowFrame;
            this.linklblSendEmail.AutoSize = true;
            this.linklblSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linklblSendEmail.ForeColor = System.Drawing.Color.Cornsilk;
            this.linklblSendEmail.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linklblSendEmail.LinkColor = System.Drawing.Color.Cornsilk;
            this.linklblSendEmail.Location = new System.Drawing.Point(62, 52);
            this.linklblSendEmail.Name = "linklblSendEmail";
            this.linklblSendEmail.Size = new System.Drawing.Size(91, 22);
            this.linklblSendEmail.TabIndex = 13;
            this.linklblSendEmail.TabStop = true;
            this.linklblSendEmail.Text = "E-Mail At";
            this.linklblSendEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSendEmail_LinkClicked);
            // 
            // frmLoginScreenTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(581, 636);
            this.Controls.Add(this.linklblSendEmail);
            this.Controls.Add(this.lblPaswordShow);
            this.Controls.Add(this.lblcCpyright);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbRememberMe);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginScreenTR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoginScreenTR";
            this.Load += new System.EventHandler(this.frmLoginScreenTR_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLoginScreenTR_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLoginScreenTR_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmLoginScreenTR_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private CheckBox cbRememberMe;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblClose;
        private Label lblEnglish;
        private Label lblcCpyright;
        private Label lblPaswordShow;
        private LinkLabel linklblSendEmail;
    }
}