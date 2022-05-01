using Business.Abstract;
using Business.DependencyReolvers.Ninject;
using Entities.Concrete;
using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Utilities.Log.FileLogger;
using Core.Utilities.Exceptions;

namespace UI.Forms.TR
{
    public partial class frmRegisterTR : Form
    {
        public frmRegisterTR()
        {
            InitializeComponent();
            accountService = InstanceFactory.GetInstance<IAccountService>();
        }

        IAccountService accountService;
        Log log = new Log();
        Account account = new Account();

        int move;
        int mouseX;
        int mouseY;

        void SendEmailValue()
        {
            frmActivationTR frmActivation = new frmActivationTR();
            frmActivation.getEmail=txtEmailAddress.Text;
            frmActivation.Show();
            this.Close();
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            account.Id = 0;
            account.Email = txtEmailAddress.Text;
            account.UserName = txtUsername.Text;
            account.Password = txtPassword.Text;

            try
            {
                if (accountService.IsAnyEmailValid(txtEmailAddress.Text).Success)
                {
                    var data = accountService.AddAccount(account);
                    log.CreateLog(txtUsername.Text);

                    MessageBox.Show(data.Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SendEmailValue();
                }
            }
            catch (EMailSymbolMissingException EmailSymbolException)
            {
              MessageBox.Show(EmailSymbolException.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRepassowrd_TextChanged(object sender, EventArgs e)
        {
           var data= accountService.CheckPassword(txtPassword.Text, txtRepassowrd.Text);
            if (!string.IsNullOrEmpty(txtRepassowrd.Text))
            {
                lblPasswordControl.Visible = true;
                lblPasswordControl.Text = data.Message;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
                lblPaswordShow.Visible = true;
            else
                lblPaswordShow.Visible = false;
        }

        private void lblPaswordShow_Click(object sender, EventArgs e)
        {
            if (lblPaswordShow.Text == "Şifreyi Göster")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtRepassowrd.UseSystemPasswordChar = true;
                lblPaswordShow.Text = "Şifreyi gizle";
            }
            else
            {
                txtRepassowrd.UseSystemPasswordChar=false;
                txtPassword.UseSystemPasswordChar = false;
                lblPaswordShow.Text = "Şifreyi Göster";
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            frmLoginScreenTR frmLoginScreen = new frmLoginScreenTR();
            frmLoginScreen.Show();
            this.Close();
        }

        private void frmRegisterTR_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void frmRegisterTR_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void frmRegisterTR_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX,
                    MousePosition.Y - mouseY);
            }
        }
    }
}
