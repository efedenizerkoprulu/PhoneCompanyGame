namespace UI.Forms.TR
{
    partial class frmActivationTR
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
            this.lblClose = new System.Windows.Forms.Label();
            this.txtActivation = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnActivation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblClose.Location = new System.Drawing.Point(492, 19);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(38, 42);
            this.lblClose.TabIndex = 30;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // txtActivation
            // 
            this.txtActivation.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtActivation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtActivation.ForeColor = System.Drawing.Color.White;
            this.txtActivation.Location = new System.Drawing.Point(33, 168);
            this.txtActivation.MaxLength = 30;
            this.txtActivation.Multiline = true;
            this.txtActivation.Name = "txtActivation";
            this.txtActivation.Size = new System.Drawing.Size(472, 49);
            this.txtActivation.TabIndex = 29;
            this.txtActivation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtActivation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActivation_KeyPress);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCode.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCode.Location = new System.Drawing.Point(33, 125);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(60, 29);
            this.lblCode.TabIndex = 28;
            this.lblCode.Text = "Kod";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTitle.Location = new System.Drawing.Point(33, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 42);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Hesap Aktifleştir";
            // 
            // btnActivation
            // 
            this.btnActivation.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnActivation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActivation.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnActivation.Location = new System.Drawing.Point(85, 248);
            this.btnActivation.Name = "btnActivation";
            this.btnActivation.Size = new System.Drawing.Size(372, 63);
            this.btnActivation.TabIndex = 31;
            this.btnActivation.Text = "hesabı Aktif Et ";
            this.btnActivation.UseVisualStyleBackColor = false;
            this.btnActivation.Click += new System.EventHandler(this.btnActivation_Click);
            // 
            // frmActivationTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(574, 352);
            this.Controls.Add(this.btnActivation);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.txtActivation);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActivationTR";
            this.Text = "frmATR";
            this.Load += new System.EventHandler(this.frmActivation_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmActivationTR_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmActivationTR_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmActivationTR_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblClose;
        private TextBox txtActivation;
        private Label lblCode;
        private Label lblTitle;
        private Button btnActivation;
    }
}