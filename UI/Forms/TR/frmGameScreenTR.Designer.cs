namespace UI.Forms.TR
{
    partial class frmGameScreenTR
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblXp = new System.Windows.Forms.Label();
            this.lblSlash = new System.Windows.Forms.Label();
            this.lblMaxXp = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblMoneyTitle = new System.Windows.Forms.Label();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.grbxCompanyAndGameInfo = new System.Windows.Forms.GroupBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblDifficultyTitle = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanyNameTitle = new System.Windows.Forms.Label();
            this.lblBossName = new System.Windows.Forms.Label();
            this.lblBoosNameTitle = new System.Windows.Forms.Label();
            this.btnMyPhones = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnMakeNewPhone = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDeleteSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbxCompanyAndGameInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.lblXp);
            this.panel1.Controls.Add(this.lblSlash);
            this.panel1.Controls.Add(this.lblMaxXp);
            this.panel1.Controls.Add(this.lblLevel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblMoney);
            this.panel1.Controls.Add(this.lblMoneyTitle);
            this.panel1.Location = new System.Drawing.Point(278, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 71);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblXp
            // 
            this.lblXp.AutoSize = true;
            this.lblXp.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblXp.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblXp.Location = new System.Drawing.Point(738, 21);
            this.lblXp.Name = "lblXp";
            this.lblXp.Size = new System.Drawing.Size(69, 29);
            this.lblXp.TabIndex = 8;
            this.lblXp.Text = "0000";
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSlash.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblSlash.Location = new System.Drawing.Point(813, 21);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(21, 29);
            this.lblSlash.TabIndex = 7;
            this.lblSlash.Text = "/";
            // 
            // lblMaxXp
            // 
            this.lblMaxXp.AutoSize = true;
            this.lblMaxXp.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMaxXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaxXp.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblMaxXp.Location = new System.Drawing.Point(840, 21);
            this.lblMaxXp.Name = "lblMaxXp";
            this.lblMaxXp.Size = new System.Drawing.Size(69, 29);
            this.lblMaxXp.TabIndex = 6;
            this.lblMaxXp.Text = "0000";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLevel.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblLevel.Location = new System.Drawing.Point(940, 21);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(27, 29);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.levelSquareImage;
            this.pictureBox1.Location = new System.Drawing.Point(915, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoney.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblMoney.Location = new System.Drawing.Point(124, 21);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(69, 29);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "0000";
            // 
            // lblMoneyTitle
            // 
            this.lblMoneyTitle.AutoSize = true;
            this.lblMoneyTitle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMoneyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoneyTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblMoneyTitle.Location = new System.Drawing.Point(28, 21);
            this.lblMoneyTitle.Name = "lblMoneyTitle";
            this.lblMoneyTitle.Size = new System.Drawing.Size(97, 29);
            this.lblMoneyTitle.TabIndex = 2;
            this.lblMoneyTitle.Text = "Money:";
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjectTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblProjectTitle.Location = new System.Drawing.Point(24, 21);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(239, 36);
            this.lblProjectTitle.TabIndex = 1;
            this.lblProjectTitle.Text = "PhoneCampany";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCopyright.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCopyright.Location = new System.Drawing.Point(45, 56);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(218, 25);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "Made By EDK Software";
            // 
            // grbxCompanyAndGameInfo
            // 
            this.grbxCompanyAndGameInfo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.grbxCompanyAndGameInfo.Controls.Add(this.btnDeleteSave);
            this.grbxCompanyAndGameInfo.Controls.Add(this.lblDifficulty);
            this.grbxCompanyAndGameInfo.Controls.Add(this.lblDifficultyTitle);
            this.grbxCompanyAndGameInfo.Controls.Add(this.lblCompanyName);
            this.grbxCompanyAndGameInfo.Controls.Add(this.lblCompanyNameTitle);
            this.grbxCompanyAndGameInfo.Controls.Add(this.lblBossName);
            this.grbxCompanyAndGameInfo.Controls.Add(this.lblBoosNameTitle);
            this.grbxCompanyAndGameInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbxCompanyAndGameInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbxCompanyAndGameInfo.ForeColor = System.Drawing.Color.Cornsilk;
            this.grbxCompanyAndGameInfo.Location = new System.Drawing.Point(993, 88);
            this.grbxCompanyAndGameInfo.Name = "grbxCompanyAndGameInfo";
            this.grbxCompanyAndGameInfo.Size = new System.Drawing.Size(278, 495);
            this.grbxCompanyAndGameInfo.TabIndex = 3;
            this.grbxCompanyAndGameInfo.TabStop = false;
            this.grbxCompanyAndGameInfo.Text = "Şirket ve Oyun Bilgileri";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDifficulty.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblDifficulty.Location = new System.Drawing.Point(26, 292);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(69, 29);
            this.lblDifficulty.TabIndex = 11;
            this.lblDifficulty.Text = "0000";
            // 
            // lblDifficultyTitle
            // 
            this.lblDifficultyTitle.AutoSize = true;
            this.lblDifficultyTitle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblDifficultyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDifficultyTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblDifficultyTitle.Location = new System.Drawing.Point(26, 251);
            this.lblDifficultyTitle.Name = "lblDifficultyTitle";
            this.lblDifficultyTitle.Size = new System.Drawing.Size(169, 29);
            this.lblDifficultyTitle.TabIndex = 10;
            this.lblDifficultyTitle.Text = "Oyun Zorluğu";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCompanyName.Location = new System.Drawing.Point(26, 204);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(69, 29);
            this.lblCompanyName.TabIndex = 9;
            this.lblCompanyName.Text = "0000";
            // 
            // lblCompanyNameTitle
            // 
            this.lblCompanyNameTitle.AutoSize = true;
            this.lblCompanyNameTitle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCompanyNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyNameTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCompanyNameTitle.Location = new System.Drawing.Point(26, 163);
            this.lblCompanyNameTitle.Name = "lblCompanyNameTitle";
            this.lblCompanyNameTitle.Size = new System.Drawing.Size(135, 29);
            this.lblCompanyNameTitle.TabIndex = 8;
            this.lblCompanyNameTitle.Text = "Şirrket Adı";
            // 
            // lblBossName
            // 
            this.lblBossName.AutoSize = true;
            this.lblBossName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblBossName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBossName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblBossName.Location = new System.Drawing.Point(26, 112);
            this.lblBossName.Name = "lblBossName";
            this.lblBossName.Size = new System.Drawing.Size(69, 29);
            this.lblBossName.TabIndex = 7;
            this.lblBossName.Text = "0000";
            // 
            // lblBoosNameTitle
            // 
            this.lblBoosNameTitle.AutoSize = true;
            this.lblBoosNameTitle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblBoosNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBoosNameTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblBoosNameTitle.Location = new System.Drawing.Point(26, 71);
            this.lblBoosNameTitle.Name = "lblBoosNameTitle";
            this.lblBoosNameTitle.Size = new System.Drawing.Size(157, 29);
            this.lblBoosNameTitle.TabIndex = 6;
            this.lblBoosNameTitle.Text = "Karekter Adı";
            // 
            // btnMyPhones
            // 
            this.btnMyPhones.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMyPhones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyPhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMyPhones.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnMyPhones.Location = new System.Drawing.Point(12, 11);
            this.btnMyPhones.Name = "btnMyPhones";
            this.btnMyPhones.Size = new System.Drawing.Size(302, 63);
            this.btnMyPhones.TabIndex = 8;
            this.btnMyPhones.Text = "Yaptığım Telefonlar";
            this.btnMyPhones.UseVisualStyleBackColor = false;
            this.btnMyPhones.Click += new System.EventHandler(this.btnMyPhones_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExitGame);
            this.panel2.Controls.Add(this.btnShop);
            this.panel2.Controls.Add(this.btnMakeNewPhone);
            this.panel2.Controls.Add(this.btnMyPhones);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 589);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 86);
            this.panel2.TabIndex = 9;
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExitGame.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnExitGame.Location = new System.Drawing.Point(968, 11);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(302, 63);
            this.btnExitGame.TabIndex = 11;
            this.btnExitGame.Text = "Çıkış yap";
            this.btnExitGame.UseVisualStyleBackColor = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShop.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnShop.Location = new System.Drawing.Point(646, 11);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(302, 63);
            this.btnShop.TabIndex = 10;
            this.btnShop.Text = "Dükkan";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnMakeNewPhone
            // 
            this.btnMakeNewPhone.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMakeNewPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeNewPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMakeNewPhone.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnMakeNewPhone.Location = new System.Drawing.Point(330, 11);
            this.btnMakeNewPhone.Name = "btnMakeNewPhone";
            this.btnMakeNewPhone.Size = new System.Drawing.Size(302, 63);
            this.btnMakeNewPhone.TabIndex = 9;
            this.btnMakeNewPhone.Text = "Yeni Telefon Yap";
            this.btnMakeNewPhone.UseVisualStyleBackColor = false;
            this.btnMakeNewPhone.Click += new System.EventHandler(this.btnMakeNewPhone_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(24, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 452);
            this.panel3.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Linen;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(772, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 452);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 452);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.GameScreenImage;
            this.pictureBox2.Location = new System.Drawing.Point(168, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(605, 464);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnDeleteSave
            // 
            this.btnDeleteSave.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSave.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDeleteSave.Location = new System.Drawing.Point(6, 339);
            this.btnDeleteSave.Name = "btnDeleteSave";
            this.btnDeleteSave.Size = new System.Drawing.Size(266, 63);
            this.btnDeleteSave.TabIndex = 12;
            this.btnDeleteSave.Text = "Save Sil";
            this.btnDeleteSave.UseVisualStyleBackColor = false;
            this.btnDeleteSave.Click += new System.EventHandler(this.btnDeleteSave_Click);
            // 
            // frmGameScreenTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grbxCompanyAndGameInfo);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblProjectTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGameScreenTR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameScreenTR";
            this.Load += new System.EventHandler(this.frmGameScreenTR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbxCompanyAndGameInfo.ResumeLayout(false);
            this.grbxCompanyAndGameInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblMoneyTitle;
        private Label lblProjectTitle;
        private Label lblCopyright;
        private GroupBox grbxCompanyAndGameInfo;
        private Label lblSlash;
        private Label lblDifficultyTitle;
        private Label lblCompanyNameTitle;
        private Label lblBoosNameTitle;
        private Button btnMyPhones;
        private Panel panel2;
        private Button btnExitGame;
        private Button btnShop;
        private Button btnMakeNewPhone;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private PictureBox pictureBox2;
        public Label lblLevel;
        public Label lblMoney;
        public Label lblXp;
        public Label lblMaxXp;
        public Label lblDifficulty;
        public Label lblCompanyName;
        public Label lblBossName;
        private Button btnDeleteSave;
    }
}