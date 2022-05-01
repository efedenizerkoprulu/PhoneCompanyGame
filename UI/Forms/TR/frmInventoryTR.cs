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
    public partial class frmInventoryTR : Form
    {
        public frmInventoryTR()
        {
            InitializeComponent();
            myProductSevice = InstanceFactory.GetInstance<IMyProductSevice>();
        }

        IMyProductSevice myProductSevice;

        public int GetAccountId;
        public int GetInventory;
        public string GetUsername;

        private void DatagridviewSettings()
        {
            dtgrdInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrdInventory.Columns[0].HeaderText = "Birleşen ID";
            dtgrdInventory.Columns[1].Visible = false;
            dtgrdInventory.Columns[2].HeaderText = "Birleşen Adı";
            dtgrdInventory.Columns[3].HeaderText = "Birleşen Tür";
            dtgrdInventory.Columns[4].Visible = false;
        }
        private void frmInventoryTR_Load(object sender, EventArgs e)
        {
            dtgrdInventory.DataSource = myProductSevice.ShowInventory().Data;
            DatagridviewSettings();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            frmCreateNewPhoneTR frmCreateNewPhone = new frmCreateNewPhoneTR();
            frmCreateNewPhone.GetAccountId = GetAccountId;
            frmCreateNewPhone.GetInventory = GetInventory;
            frmCreateNewPhone.GetUsername = GetUsername;
            frmCreateNewPhone.Show();
            this.Close();
        }
    }
}
