using Business.Abstract;
using Business.Constants;
using Business.DependencyReolvers.Ninject;
using Core.Utilities.Log.FileLogger;
using Entities.Concrete;
using System.Threading;
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
    public partial class FrmNewGameTR : Form
    {
        public FrmNewGameTR()
        {
            InitializeComponent();
            gameDataService = InstanceFactory.GetInstance<IGameDataService>();
        }
        public int GetAccountId;
        public int getInventoryId;
        public string GetAccountName;

        void NewGame()
        {
            gameData.Id = 0;
            gameData.AccountID = GetAccountId;
            gameData.CompanyName = txtCompanyName.Text;
            gameData.BossName = txtBossName.Text;

            if (rbEasy.Checked)
            {
                gameData.GameDifficulty = "Easy";
                gameData.Money = 2000;
            }

            else if (rbNormal.Checked)
            {
                gameData.GameDifficulty = "Normal";
                gameData.Money = 1750;
            }

            else
            {
                gameData.GameDifficulty = "Hard";
                gameData.Money = 1500;
            }

        }

        IGameDataService gameDataService;
        GameData gameData = new GameData();
        Log log = new Log();

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            NewGame();

            try
            {
                var Data = gameDataService.StartNewGame(gameData);
                MessageBox.Show(Data.Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(2000);
                frmGameScreenTR frmGameScreen = new frmGameScreenTR();
                frmGameScreen.GetAccountId = GetAccountId;
                frmGameScreen.GetInventory = getInventoryId;
                frmGameScreen.GetUsername = GetAccountName;
                frmGameScreen.Show();
                this.Close();
            }
            catch (Exception exception)
            {
                log.WriteLog(GetAccountName, exception.Message);
                MessageBox.Show(MessagesTR.GeneralError, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmNewGameTR_Load(object sender, EventArgs e)
        {

           
        }

        private void txtBossName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);

        }

        private void txtCompanyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
