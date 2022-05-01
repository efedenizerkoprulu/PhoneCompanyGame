namespace UI.Forms.TR
{
    partial class frmCreateNewPhoneTR
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDisplay = new System.Windows.Forms.ComboBox();
            this.cbRam = new System.Windows.Forms.ComboBox();
            this.cbMotherboard = new System.Windows.Forms.ComboBox();
            this.cbCpu = new System.Windows.Forms.ComboBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblShopTitle = new System.Windows.Forms.Label();
            this.txtPhoneName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGeneratePhone = new System.Windows.Forms.Button();
            this.pcbInventory = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPiece = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInventory)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblUsername.Location = new System.Drawing.Point(530, 151);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 29);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Cpu";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPassword.Location = new System.Drawing.Point(530, 259);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 29);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Anakart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(530, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ram";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(530, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Display";
            // 
            // cbDisplay
            // 
            this.cbDisplay.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbDisplay.DisplayMember = "ItemName";
            this.cbDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDisplay.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDisplay.ForeColor = System.Drawing.Color.Cornsilk;
            this.cbDisplay.FormattingEnabled = true;
            this.cbDisplay.Location = new System.Drawing.Point(530, 408);
            this.cbDisplay.Name = "cbDisplay";
            this.cbDisplay.Size = new System.Drawing.Size(367, 45);
            this.cbDisplay.TabIndex = 21;
            this.cbDisplay.ValueMember = "Id";
            this.cbDisplay.SelectedIndexChanged += new System.EventHandler(this.cbDisplay_SelectedIndexChanged);
            // 
            // cbRam
            // 
            this.cbRam.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbRam.DisplayMember = "ItemName";
            this.cbRam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRam.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRam.ForeColor = System.Drawing.Color.Cornsilk;
            this.cbRam.FormattingEnabled = true;
            this.cbRam.Location = new System.Drawing.Point(530, 509);
            this.cbRam.Name = "cbRam";
            this.cbRam.Size = new System.Drawing.Size(367, 45);
            this.cbRam.TabIndex = 22;
            this.cbRam.ValueMember = "Id";
            this.cbRam.SelectedIndexChanged += new System.EventHandler(this.cbRam_SelectedIndexChanged);
            // 
            // cbMotherboard
            // 
            this.cbMotherboard.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbMotherboard.DisplayMember = "ItemName";
            this.cbMotherboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMotherboard.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMotherboard.ForeColor = System.Drawing.Color.Cornsilk;
            this.cbMotherboard.FormattingEnabled = true;
            this.cbMotherboard.Location = new System.Drawing.Point(530, 299);
            this.cbMotherboard.Name = "cbMotherboard";
            this.cbMotherboard.Size = new System.Drawing.Size(367, 45);
            this.cbMotherboard.TabIndex = 23;
            this.cbMotherboard.ValueMember = "Id";
            this.cbMotherboard.SelectedIndexChanged += new System.EventHandler(this.cbMotherboard_SelectedIndexChanged);
            // 
            // cbCpu
            // 
            this.cbCpu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbCpu.DisplayMember = "ItemName";
            this.cbCpu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCpu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCpu.ForeColor = System.Drawing.Color.Cornsilk;
            this.cbCpu.FormattingEnabled = true;
            this.cbCpu.Location = new System.Drawing.Point(530, 193);
            this.cbCpu.Name = "cbCpu";
            this.cbCpu.Size = new System.Drawing.Size(367, 45);
            this.cbCpu.TabIndex = 24;
            this.cbCpu.ValueMember = "Id";
            this.cbCpu.SelectedValueChanged += new System.EventHandler(this.cbCpu_SelectedValueChanged);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCopyright.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCopyright.Location = new System.Drawing.Point(44, 51);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(218, 25);
            this.lblCopyright.TabIndex = 26;
            this.lblCopyright.Text = "Made By EDK Software";
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjectTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblProjectTitle.Location = new System.Drawing.Point(23, 16);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(239, 36);
            this.lblProjectTitle.TabIndex = 25;
            this.lblProjectTitle.Text = "PhoneCampany";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.lblShopTitle);
            this.panel1.Location = new System.Drawing.Point(288, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 65);
            this.panel1.TabIndex = 27;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblClose.Location = new System.Drawing.Point(624, 11);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(37, 36);
            this.lblClose.TabIndex = 28;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblShopTitle
            // 
            this.lblShopTitle.AutoSize = true;
            this.lblShopTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShopTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblShopTitle.Location = new System.Drawing.Point(18, 14);
            this.lblShopTitle.Name = "lblShopTitle";
            this.lblShopTitle.Size = new System.Drawing.Size(182, 32);
            this.lblShopTitle.TabIndex = 7;
            this.lblShopTitle.Text = "Telefon Üret";
            // 
            // txtPhoneName
            // 
            this.txtPhoneName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPhoneName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneName.ForeColor = System.Drawing.Color.White;
            this.txtPhoneName.Location = new System.Drawing.Point(44, 176);
            this.txtPhoneName.MaxLength = 30;
            this.txtPhoneName.Multiline = true;
            this.txtPhoneName.Name = "txtPhoneName";
            this.txtPhoneName.Size = new System.Drawing.Size(422, 49);
            this.txtPhoneName.TabIndex = 29;
            this.txtPhoneName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(44, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Telefon Adı";
            // 
            // cbColor
            // 
            this.cbColor.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbColor.DisplayMember = "ColorName";
            this.cbColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbColor.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbColor.ForeColor = System.Drawing.Color.Cornsilk;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(44, 290);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(422, 45);
            this.cbColor.TabIndex = 31;
            this.cbColor.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(44, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "Telefon Renk";
            // 
            // btnGeneratePhone
            // 
            this.btnGeneratePhone.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGeneratePhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGeneratePhone.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnGeneratePhone.Location = new System.Drawing.Point(273, 593);
            this.btnGeneratePhone.Name = "btnGeneratePhone";
            this.btnGeneratePhone.Size = new System.Drawing.Size(422, 60);
            this.btnGeneratePhone.TabIndex = 32;
            this.btnGeneratePhone.Text = "Telefon Üret";
            this.btnGeneratePhone.UseVisualStyleBackColor = false;
            this.btnGeneratePhone.Click += new System.EventHandler(this.btnGeneratePhone_Click);
            // 
            // pcbInventory
            // 
            this.pcbInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbInventory.Image = global::UI.Properties.Resources._38964_box_product_package_generic_inventory_icon;
            this.pcbInventory.Location = new System.Drawing.Point(24, 44);
            this.pcbInventory.Name = "pcbInventory";
            this.pcbInventory.Size = new System.Drawing.Size(81, 62);
            this.pcbInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbInventory.TabIndex = 33;
            this.pcbInventory.TabStop = false;
            this.pcbInventory.Click += new System.EventHandler(this.pcbInventory_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(8, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Envanter";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pcbInventory);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(1, 584);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 109);
            this.panel2.TabIndex = 35;
            // 
            // txtPiece
            // 
            this.txtPiece.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPiece.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPiece.ForeColor = System.Drawing.Color.White;
            this.txtPiece.Location = new System.Drawing.Point(43, 403);
            this.txtPiece.MaxLength = 30;
            this.txtPiece.Multiline = true;
            this.txtPiece.Name = "txtPiece";
            this.txtPiece.Size = new System.Drawing.Size(422, 49);
            this.txtPiece.TabIndex = 37;
            this.txtPiece.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPiece.TextChanged += new System.EventHandler(this.txtPiece_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(43, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "Adet";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCost.ForeColor = System.Drawing.Color.White;
            this.txtCost.Location = new System.Drawing.Point(45, 505);
            this.txtCost.MaxLength = 30;
            this.txtCost.Multiline = true;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(422, 49);
            this.txtCost.TabIndex = 39;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(46, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 29);
            this.label7.TabIndex = 38;
            this.label7.Text = "Maliyet";
            // 
            // frmCreateNewPhoneTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(961, 693);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPiece);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGeneratePhone);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhoneName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblProjectTitle);
            this.Controls.Add(this.cbCpu);
            this.Controls.Add(this.cbMotherboard);
            this.Controls.Add(this.cbRam);
            this.Controls.Add(this.cbDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateNewPhoneTR";
            this.Text = "\"";
            this.Load += new System.EventHandler(this.frmCreateNewPhoneTR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInventory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private Label label1;
        private Label label2;
        private ComboBox cbDisplay;
        private ComboBox cbRam;
        private ComboBox cbMotherboard;
        private ComboBox cbCpu;
        private Label lblCopyright;
        private Label lblProjectTitle;
        private Panel panel1;
        private Label lblShopTitle;
        private Label lblClose;
        private TextBox txtPhoneName;
        private Label label3;
        private ComboBox cbColor;
        private Label label4;
        private Button btnGeneratePhone;
        private PictureBox pcbInventory;
        private Label label5;
        private Panel panel2;
        private TextBox txtPiece;
        private Label label6;
        private TextBox txtCost;
        private Label label7;
    }
}