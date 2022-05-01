using Business.Abstract;
using Business.Constants;
using Business.DependencyReolvers.Ninject;
using Core.Utilities.Log.FileLogger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms.Eng;

namespace UI.Forms.TR
{
    public partial class frmLoginScreenTR : Form
    {
        public frmLoginScreenTR()
        {
            InitializeComponent();
            accountService = InstanceFactory.GetInstance<IAccountService>();
        }

        void RememberMeSaveValue()
        {
            // save the most recently entered user name
            if (cbRememberMe.Checked )
            {
                UI.Properties.Settings.Default.UserName = txtUsername.Text;
                UI.Properties.Settings.Default.Save();
            }
        }

        void RememberMeLoadValue()
        {
            // load the most recently entered user name
            txtUsername.Text = UI.Properties.Settings.Default.UserName;
        }

        IAccountService accountService;
        Log log = new Log();
        
       
        int move;
        int mouseX;
        int mouseY;
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var getData = accountService.LoginGane(txtUsername.Text, txtPassword.Text);
                var GetId = accountService.GetAccountID(txtUsername.Text, txtPassword.Text).Data;

                if (getData.Success)
                {
                    frmMainMenuTR frmMainMenu = new frmMainMenuTR();
                    frmMainMenu.GetUsername = txtUsername.Text;
                    frmMainMenu.GetID = GetId.Id;


                    RememberMeSaveValue();
                    frmMainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(getData.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

               
            }
            catch (Exception exception)
            {
                log.WriteLog(txtUsername.Text, exception.Message);
                MessageBox.Show(MessagesTR.GeneralError, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // move the form 
        private void frmLoginScreenTR_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void frmLoginScreenTR_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void frmLoginScreenTR_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, 
                    MousePosition.Y - mouseY);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            // Close program

            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // is empty password textbox?

            if (!string.IsNullOrEmpty(txtPassword.Text))
                lblPaswordShow.Visible = true;
            else
                lblPaswordShow.Visible = false;

        }

        private void lblPaswordShow_Click(object sender, EventArgs e)
        {
            // show password

            if (lblPaswordShow.Text== "Şifreyi Göster")
            {
                txtPassword.UseSystemPasswordChar = true;
                lblPaswordShow.Text = "Şifreyi gizle";
            }
            else
            {
                txtPassword.UseSystemPasswordChar= false;
                lblPaswordShow.Text = "Şifreyi Göster";
            }
        }

        private void frmLoginScreenTR_Load(object sender, EventArgs e)
        {
            RememberMeLoadValue();
        }

        private void linklblSendEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open email app and send email

            Process.Start(new ProcessStartInfo("mailto:efedenizerkoprulu@outlook.com") { UseShellExecute = true });
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegisterTR frmRegister = new frmRegisterTR();
            frmRegister.Show();
            this.Hide();
        }
        
        private void lblEnglish_Click(object sender, EventArgs e)
        {
            UI.Properties.Settings.Default.lang = "English";
            UI.Properties.Settings.Default.Save();
            this.Close();


        }
    }
}
