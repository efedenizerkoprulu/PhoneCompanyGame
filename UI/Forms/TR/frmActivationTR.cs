using Business.Abstract;
using Business.DependencyReolvers.Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.TR
{
    public partial class frmActivationTR : Form
    {
        public frmActivationTR()
        {
            InitializeComponent();
            accountService = InstanceFactory.GetInstance<IAccountService>();
        }
        IAccountService accountService;
        public string getEmail;
        int Code;

        int move;
        int mouseX;
        int mouseY;
       

        void OpenForm()
        {
            frmLoginScreenTR frmLoginScreen = new frmLoginScreenTR();
            frmLoginScreen.Show();
            this.Close();
        }
        private void frmActivation_Load(object sender, EventArgs e)
        {
            

            Random random = new Random();
            Code = random.Next(1000, 10000);

            accountService.SendEmail(getEmail,Code);
        }

        private void btnActivation_Click(object sender, EventArgs e)
        {
           var data= accountService.ActivationAccount(ref Code, txtActivation.Text);
            try
            {
                if (data.Success)
                {
                    accountService.MakeActiveData(getEmail);
                    MessageBox.Show(data.Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenForm();
                    
                }
                else
                    MessageBox.Show(data.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            OpenForm();
        }

        private void frmActivationTR_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX,
                    MousePosition.Y - mouseY);
            }
        }

        private void frmActivationTR_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void frmActivationTR_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void txtActivation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
