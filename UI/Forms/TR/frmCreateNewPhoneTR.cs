using Business.Abstract;
using Business.DependencyReolvers.Ninject;
using Core.Utilities.Log.FileLogger;
using Entities.Concrete;
using System.Threading;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Utilities.Exceptions;
using Business.Constants;

namespace UI.Forms.TR
{
    public partial class frmCreateNewPhoneTR : Form
    {
        public frmCreateNewPhoneTR()
        {
            InitializeComponent();
            myProductSevice = InstanceFactory.GetInstance<IMyProductSevice>();
        }
        IMyProductSevice myProductSevice;
        Log log = new Log();
        MyProduct myProduct = new MyProduct();

        public int GetAccountId;
        public int GetInventory;
        public int GameDataId;
        public string ProductName;
        public string GetUsername;
        public decimal cost = 0;
        public decimal totalCost = 1;
        int piece;

        decimal priceTotal = 0;


        void SaveCost()
        {
            var cpuPrice = cbCpu.SelectedIndex >= 0 ? myProductSevice.GetUnitPrice(Convert.ToDecimal(cbCpu.SelectedValue)).Data : 0;
            var mainPrice = cbMotherboard.SelectedIndex >= 0 ? myProductSevice.GetUnitPrice(Convert.ToDecimal(cbMotherboard.SelectedValue)).Data : 0;
            var displayPrice = cbDisplay.SelectedIndex >= 0 ? myProductSevice.GetUnitPrice(Convert.ToDecimal(cbDisplay.SelectedValue)).Data : 0;
            var ramPrice = cbRam.SelectedIndex >= 0 ? myProductSevice.GetUnitPrice(Convert.ToDecimal(cbRam.SelectedValue)).Data : 0;
            
            priceTotal = cpuPrice + mainPrice + displayPrice + ramPrice;
        }

        private void frmCreateNewPhoneTR_Load(object sender, EventArgs e)
        {
            cbCpu.DataSource = myProductSevice.GetYourItems("Cpu", GetInventory).Data;
            cbDisplay.DataSource = myProductSevice.GetYourItems("Display", GetInventory).Data;
            cbMotherboard.DataSource = myProductSevice.GetYourItems("Motherboard", GetInventory).Data;
            cbRam.DataSource = myProductSevice.GetYourItems("Ram", GetInventory).Data;
            cbColor.DataSource = myProductSevice.GetPhoneColors().Data;

            SaveCost();
        }

        private void pcbInventory_Click(object sender, EventArgs e)
        {
            frmInventoryTR frmInventory = new frmInventoryTR();
            frmInventory.GetAccountId = GetAccountId;
            frmInventory.GetInventory = GetInventory;
            frmInventory.GetUsername = GetUsername;
            frmInventory.Show();
            this.Close();
        }

        private void cbCpu_SelectedValueChanged(object sender, EventArgs e)
        {
            SaveCost();
        }

        private void cbMotherboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCost();
        }

        private void cbDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCost();
        }

        private void cbRam_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCost();
        }

        private void btnGeneratePhone_Click(object sender, EventArgs e)
        {
            myProduct.Id = 0;
            myProduct.ProductName = txtPhoneName.Text;
            myProduct.ProductSalesGain = 0;
            myProduct.ProductColorId = Convert.ToInt32(cbColor.SelectedValue);
            myProduct.AveragePoint = 0;
            myProduct.GameDataId = GameDataId;

            ProductName=txtPhoneName.Text;

            try
            {
                if ((myProductSevice.CheckMissingPart(cbRam.Text, cbCpu.Text, cbMotherboard.Text, cbDisplay.Text).Success) && myProductSevice.IsExistProductName(txtPhoneName.Text).Success)
                {
                    var data = myProductSevice.CreatePhone(myProduct);
                    MessageBox.Show(data.Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(200);


                    frmProductPointRatingTR frmProductPointRating = new frmProductPointRatingTR();
                    frmProductPointRating.GetAccountId = GetAccountId;
                    frmProductPointRating.GetInventory = GetInventory;
                    frmProductPointRating.GetUsername = GetUsername;
                    frmProductPointRating.GetGameDataId = GameDataId;
                    frmProductPointRating.totalcost = totalCost;
                    frmProductPointRating.GetPhoneName = ProductName;
                    frmProductPointRating.Show();
                    this.Close();

                }
            }
            catch(ProductNameAvailableException ProductNameAvailableException)
            {
                MessageBox.Show(ProductNameAvailableException.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(MessagesTR.GeneralError,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                log.WriteLog(GetUsername, exception.Message);
            }
        }

        private void txtPiece_TextChanged(object sender, EventArgs e)
        {
            piece = !String.IsNullOrEmpty(txtPiece.Text) ? int.Parse(txtPiece.Text) : 0;

            totalCost = (priceTotal * piece);
            txtCost.Text = (totalCost/5).ToString();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
           
           
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
