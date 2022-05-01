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
    public partial class frmMyPhonesTR : Form
    {
        public frmMyPhonesTR()
        {
            InitializeComponent();
            myProductSevice=InstanceFactory.GetInstance<IMyProductSevice>();
        }

        IMyProductSevice myProductSevice;

        public int GetAccountId;
        public int GetInventory;
        public string GetUsername;
        public int GetGameData;

        private void DatagridviewSettings()
        {
            dtgrdInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrdInventory.Columns[0].HeaderText = "Telefon ID";
            dtgrdInventory.Columns[1].HeaderText = "Telefon Ad";
            dtgrdInventory.Columns[2].HeaderText = "Telefon Rengi";
            dtgrdInventory.Columns[3].HeaderText = "Ortalama Puan";
            dtgrdInventory.Columns[4].HeaderText = "Kazanç";
            dtgrdInventory.Columns[5].HeaderText = "Çok Satan Ürün";
        }

        private void frmMyPhonesTR_Load(object sender, EventArgs e)
        {
            
            dtgrdInventory.DataSource = myProductSevice.ListProduct().Data;
            DatagridviewSettings();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            frmGameScreenTR frmGameScreen = new frmGameScreenTR();
            frmGameScreen.GetAccountId = GetAccountId;
            frmGameScreen.GetInventory = GetInventory;
            frmGameScreen.GetUsername = GetUsername;
            frmGameScreen.GetGameData = GetGameData;
            frmGameScreen.Show();
            this.Close();
        }
    }
}
