namespace UI.Forms.TR
{
    partial class FrmNewGameTR
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLine = new System.Windows.Forms.Label();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.lblGameDificulty = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtBossName = new System.Windows.Forms.TextBox();
            this.lblBoosName = new System.Windows.Forms.Label();
            this.btnStartNewGame = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTitle.Location = new System.Drawing.Point(237, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(314, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Yeni Şirket Yarat";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.lblLine);
            this.panel1.Controls.Add(this.rbHard);
            this.panel1.Controls.Add(this.rbNormal);
            this.panel1.Controls.Add(this.rbEasy);
            this.panel1.Controls.Add(this.lblGameDificulty);
            this.panel1.Controls.Add(this.txtCompanyName);
            this.panel1.Controls.Add(this.lblCompanyName);
            this.panel1.Controls.Add(this.txtBossName);
            this.panel1.Controls.Add(this.lblBoosName);
            this.panel1.Location = new System.Drawing.Point(21, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 362);
            this.panel1.TabIndex = 2;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLine.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblLine.Location = new System.Drawing.Point(505, 130);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(166, 29);
            this.lblLine.TabIndex = 11;
            this.lblLine.Text = "-----------------";
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.BackColor = System.Drawing.Color.Transparent;
            this.rbHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbHard.ForeColor = System.Drawing.Color.Cornsilk;
            this.rbHard.Location = new System.Drawing.Point(547, 232);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(62, 29);
            this.rbHard.TabIndex = 10;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Zor";
            this.rbHard.UseVisualStyleBackColor = false;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNormal.ForeColor = System.Drawing.Color.Cornsilk;
            this.rbNormal.Location = new System.Drawing.Point(547, 197);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(95, 29);
            this.rbNormal.TabIndex = 9;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEasy.ForeColor = System.Drawing.Color.Cornsilk;
            this.rbEasy.Location = new System.Drawing.Point(547, 162);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(83, 29);
            this.rbEasy.TabIndex = 8;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Kolay";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // lblGameDificulty
            // 
            this.lblGameDificulty.AutoSize = true;
            this.lblGameDificulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGameDificulty.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblGameDificulty.Location = new System.Drawing.Point(501, 101);
            this.lblGameDificulty.Name = "lblGameDificulty";
            this.lblGameDificulty.Size = new System.Drawing.Size(169, 29);
            this.lblGameDificulty.TabIndex = 7;
            this.lblGameDificulty.Text = "Oyun Zorluğu";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCompanyName.ForeColor = System.Drawing.Color.White;
            this.txtCompanyName.Location = new System.Drawing.Point(33, 222);
            this.txtCompanyName.MaxLength = 30;
            this.txtCompanyName.Multiline = true;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(368, 49);
            this.txtCompanyName.TabIndex = 6;
            this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCompanyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompanyName_KeyPress);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCompanyName.Location = new System.Drawing.Point(33, 175);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(147, 29);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "Şirketin Adı";
            // 
            // txtBossName
            // 
            this.txtBossName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBossName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBossName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBossName.ForeColor = System.Drawing.Color.White;
            this.txtBossName.Location = new System.Drawing.Point(33, 101);
            this.txtBossName.MaxLength = 30;
            this.txtBossName.Multiline = true;
            this.txtBossName.Name = "txtBossName";
            this.txtBossName.Size = new System.Drawing.Size(368, 49);
            this.txtBossName.TabIndex = 4;
            this.txtBossName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBossName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBossName_KeyPress);
            // 
            // lblBoosName
            // 
            this.lblBoosName.AutoSize = true;
            this.lblBoosName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBoosName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblBoosName.Location = new System.Drawing.Point(33, 54);
            this.lblBoosName.Name = "lblBoosName";
            this.lblBoosName.Size = new System.Drawing.Size(177, 29);
            this.lblBoosName.TabIndex = 3;
            this.lblBoosName.Text = "Karakterin Adı";
            // 
            // btnStartNewGame
            // 
            this.btnStartNewGame.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnStartNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartNewGame.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnStartNewGame.Location = new System.Drawing.Point(179, 479);
            this.btnStartNewGame.Name = "btnStartNewGame";
            this.btnStartNewGame.Size = new System.Drawing.Size(372, 63);
            this.btnStartNewGame.TabIndex = 7;
            this.btnStartNewGame.Text = "Oyuna Başla";
            this.btnStartNewGame.UseVisualStyleBackColor = false;
            this.btnStartNewGame.Click += new System.EventHandler(this.btnStartNewGame_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblClose.Location = new System.Drawing.Point(728, 29);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(38, 42);
            this.lblClose.TabIndex = 9;
            this.lblClose.Text = "x";
            // 
            // FrmNewGameTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(803, 564);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnStartNewGame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewGameTR";
            this.Text = "FrmNewGameTR";
            this.Load += new System.EventHandler(this.FrmNewGameTR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Label lblBoosName;
        private Label lblLine;
        private RadioButton rbHard;
        private RadioButton rbNormal;
        private RadioButton rbEasy;
        private Label lblGameDificulty;
        private TextBox txtCompanyName;
        private Label lblCompanyName;
        private TextBox txtBossName;
        private Button btnStartNewGame;
        private Label lblClose;
    }
}