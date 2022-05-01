namespace UI.Forms.Eng
{
    partial class frmLoginENG
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
            this.linklblSendEmail = new System.Windows.Forms.LinkLabel();
            this.lblPaswordShow = new System.Windows.Forms.Label();
            this.lblcCpyright = new System.Windows.Forms.Label();
            this.lblEngTurkish = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbRememberMe = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linklblSendEmail
            // 
            this.linklblSendEmail.ActiveLinkColor = System.Drawing.SystemColors.WindowFrame;
            this.linklblSendEmail.AutoSize = true;
            this.linklblSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linklblSendEmail.ForeColor = System.Drawing.Color.Cornsilk;
            this.linklblSendEmail.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linklblSendEmail.LinkColor = System.Drawing.Color.Cornsilk;
            this.linklblSendEmail.Location = new System.Drawing.Point(52, 47);
            this.linklblSendEmail.Name = "linklblSendEmail";
            this.linklblSendEmail.Size = new System.Drawing.Size(118, 22);
            this.linklblSendEmail.TabIndex = 26;
            this.linklblSendEmail.TabStop = true;
            this.linklblSendEmail.Text = "Send E-Mail";
            // 
            // lblPaswordShow
            // 
            this.lblPaswordShow.AutoSize = true;
            this.lblPaswordShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaswordShow.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPaswordShow.Location = new System.Drawing.Point(372, 263);
            this.lblPaswordShow.Name = "lblPaswordShow";
            this.lblPaswordShow.Size = new System.Drawing.Size(152, 22);
            this.lblPaswordShow.TabIndex = 25;
            this.lblPaswordShow.Text = "Show Password";
            this.lblPaswordShow.Visible = false;
            // 
            // lblcCpyright
            // 
            this.lblcCpyright.AutoSize = true;
            this.lblcCpyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcCpyright.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblcCpyright.Location = new System.Drawing.Point(353, 598);
            this.lblcCpyright.Name = "lblcCpyright";
            this.lblcCpyright.Size = new System.Drawing.Size(216, 22);
            this.lblcCpyright.TabIndex = 24;
            this.lblcCpyright.Text = "Made by EDK Software";
            // 
            // lblEngTurkish
            // 
            this.lblEngTurkish.AutoSize = true;
            this.lblEngTurkish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEngTurkish.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblEngTurkish.Location = new System.Drawing.Point(12, 596);
            this.lblEngTurkish.Name = "lblEngTurkish";
            this.lblEngTurkish.Size = new System.Drawing.Size(77, 22);
            this.lblEngTurkish.TabIndex = 23;
            this.lblEngTurkish.Text = "Turkish";
            this.lblEngTurkish.Click += new System.EventHandler(this.lblEngTurkish_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblClose.Location = new System.Drawing.Point(520, 16);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(38, 42);
            this.lblClose.TabIndex = 22;
            this.lblClose.Text = "x";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRegister.Location = new System.Drawing.Point(88, 477);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(372, 60);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Register Game";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnLogin.Location = new System.Drawing.Point(88, 404);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(372, 63);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.BackColor = System.Drawing.Color.Transparent;
            this.cbRememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRememberMe.ForeColor = System.Drawing.Color.Cornsilk;
            this.cbRememberMe.Location = new System.Drawing.Point(317, 343);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Padding = new System.Windows.Forms.Padding(5, 2, 10, 2);
            this.cbRememberMe.Size = new System.Drawing.Size(207, 37);
            this.cbRememberMe.TabIndex = 19;
            this.cbRememberMe.Text = "Remember Me";
            this.cbRememberMe.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(52, 288);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(472, 49);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPassword.Location = new System.Drawing.Point(52, 245);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(128, 29);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(52, 181);
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
            this.lblUsername.Location = new System.Drawing.Point(52, 138);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(132, 29);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTitle.Location = new System.Drawing.Point(52, 69);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 42);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Log In";
            // 
            // frmLoginENG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(581, 636);
            this.Controls.Add(this.linklblSendEmail);
            this.Controls.Add(this.lblPaswordShow);
            this.Controls.Add(this.lblcCpyright);
            this.Controls.Add(this.lblEngTurkish);
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
            this.Name = "frmLoginENG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoginENG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linklblSendEmail;
        private Label lblPaswordShow;
        private Label lblcCpyright;
        private Label lblEngTurkish;
        private Label lblClose;
        private Button btnRegister;
        private Button btnLogin;
        private CheckBox cbRememberMe;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblTitle;
    }
}