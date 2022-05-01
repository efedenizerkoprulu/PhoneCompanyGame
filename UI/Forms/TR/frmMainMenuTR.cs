using Business.Abstract;
using Business.Constants;
using Business.DependencyReolvers.Ninject;
using Core.Utilities.Log.FileLogger;
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
    public partial class frmMainMenuTR : Form
    {
        public frmMainMenuTR()
        {
            InitializeComponent();
            accountService=InstanceFactory.GetInstance<IAccountService>();
            gameDataService=InstanceFactory.GetInstance<IGameDataService>();
        }

        public int GetID;
        public int InventoryId;
        public string GetUsername;

        int move;
        int mouseX;
        int mouseY;


        void OpenNewGaneForm()
        {
            FrmNewGameTR frmNewGame = new FrmNewGameTR();
            frmNewGame.GetAccountId = GetID;
            frmNewGame.getInventoryId = InventoryId;
            frmNewGame.Show();
            this.Close();
        }

        IAccountService accountService;
        IGameDataService gameDataService;
        Log log = new Log();
        private void frmMainMenuTR_Load(object sender, EventArgs e)
        {
            InventoryId = accountService.GetInventoryId(GetID).Data;
            lblAccountName.Text = GetUsername;

            if (!(gameDataService.IsExxsistGameData(GetID).Success))
            {
                btnPlayGame.Enabled = false;
            }
        }

        private void btnExitAccount_Click(object sender, EventArgs e)
        {
            frmLoginScreenTR frmLoginScreen = new frmLoginScreenTR();
            frmLoginScreen.Show();
            this.Close();
        }

        private void btnAboutGame_Click(object sender, EventArgs e)
        {
            frmAboutGameTR frmAboutGame = new frmAboutGameTR();
            frmAboutGame.Show();
            this.Close();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(lblAccountName.Text + MessagesTR.IsDeleteAccount, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    var Data = accountService.DeleteAccount(GetID);
                    if (Data.Success)
                    {
                        MessageBox.Show(Data.Message,"bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        frmLoginScreenTR frmLoginScreen = new frmLoginScreenTR();
                        frmLoginScreen.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception exception)
            {
                log.WriteLog(lblAccountName.Text,exception.Message);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
                if (gameDataService.IsExxsistGameData(GetID).Success)
            {
                DialogResult result = MessageBox.Show(MessagesTR.DeleteOldSaveMessage, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    accountService.DeleteInventory(GetID);
                    gameDataService.MakeDsableOldData(GetID);
                    OpenNewGaneForm();
                }
            }
            else
                OpenNewGaneForm();

        }

        private void frmMainMenuTR_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void frmMainMenuTR_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void frmMainMenuTR_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX,
                    MousePosition.Y - mouseY);
            }
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
           

            frmGameScreenTR frmGameScreen = new frmGameScreenTR();
            frmGameScreen.GetAccountId = GetID;
            frmGameScreen.GetInventory = InventoryId;
            frmGameScreen.GetUsername = GetUsername;
            frmGameScreen.Show();
            this.Close();
        }
    }
}
