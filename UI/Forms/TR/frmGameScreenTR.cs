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
    public partial class frmGameScreenTR : Form
    {
        public frmGameScreenTR()
        {
            InitializeComponent(); gameDataService = InstanceFactory.GetInstance<IGameDataService>();
        }

        public void loadGameDataForId()
        {
            var getData = gameDataService.GetGameDataById(GetAccountId).Data;
            lblBossName.Text = getData.BossName;
            lblCompanyName.Text = getData.CompanyName;
            lblDifficulty.Text = getData.GameDifficulty;
            lblLevel.Text = getData.Level.ToString();
            lblMoney.Text = getData.Money.ToString();
            lblMaxXp.Text = getData.XpLimit.ToString();
            lblXp.Text = getData.Xp.ToString();
            GetGameData = getData.Id;
        }


        IGameDataService gameDataService;
        Log log = new Log();
        public int GetAccountId;
        public int GetInventory;
        public string GetUsername;
        public int GetGameData;
        private void frmGameScreenTR_Load(object sender, EventArgs e)
        {
            loadGameDataForId();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            frmShopTR frmShop = new frmShopTR();
            frmShop.getMoney = Convert.ToDecimal(lblMoney.Text);
            frmShop.GetAccountId = GetAccountId;
            frmShop.getInventoryId = GetInventory;
            frmShop.GetUsername = GetUsername;
            frmShop.getLevel = Convert.ToByte(lblLevel.Text);
            frmShop.Show();
            this.Hide();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            frmMainMenuTR frmMainMenu = new frmMainMenuTR();
            frmMainMenu.GetUsername = GetUsername;
            frmMainMenu.GetID = GetAccountId;
            frmMainMenu.Show();
            this.Close();
        }

        private void btnMyPhones_Click(object sender, EventArgs e)
        {
            frmMyPhonesTR frmMyPhones = new frmMyPhonesTR();
            frmMyPhones.GetInventory = GetInventory;
            frmMyPhones.GetAccountId = GetAccountId;
            frmMyPhones.GetUsername = GetUsername;
            frmMyPhones.GetGameData = GetGameData;
            frmMyPhones.Show();
            this.Close();
        }

        private void btnMakeNewPhone_Click(object sender, EventArgs e)
        {
            frmCreateNewPhoneTR frmCreateNewPhone = new frmCreateNewPhoneTR();
            frmCreateNewPhone.GetInventory = GetInventory;
            frmCreateNewPhone.GetAccountId=GetAccountId;
            frmCreateNewPhone.GetUsername = GetUsername;
            frmCreateNewPhone.GameDataId = GetGameData;
            frmCreateNewPhone.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(MessagesTR.IsDeleteSaveMessage, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                var data = gameDataService.MakePassiveSave(GetGameData);
                MessageBox.Show(MessagesTR.DeletedSaveMessage, "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                frmMainMenuTR frmMainMenu = new frmMainMenuTR();
                frmMainMenu.GetID = GetAccountId;
                frmMainMenu.GetUsername= GetUsername;
                frmMainMenu.Show();
                this.Close();
            }
        }
    }
}
