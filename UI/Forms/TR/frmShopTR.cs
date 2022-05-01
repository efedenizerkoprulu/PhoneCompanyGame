using Business.Abstract;
using Business.DependencyReolvers.Ninject;
using Core.Utilities.Exceptions;
using Core.Utilities.Log.FileLogger;
using Entities.Concrete;
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

namespace UI.Forms.TR
{
    public partial class frmShopTR : Form
    {
        public frmShopTR()
        {
            InitializeComponent();
            gameDataService = InstanceFactory.GetInstance<IGameDataService>();
        }

        public decimal getMoney;
        public int GetAccountId;
        public int getInventoryId;
        public byte getLevel;
        public string GetUsername;

        InventoryItem inventoryItem = new InventoryItem();
        ShopDTO shopDTO = new ShopDTO();

        void BuyItem(ShopDTO shopDTO, string Type, byte UnlockLevel )
        {
            shopDTO.ID = 0;
            inventoryItem.InventoryId = getInventoryId;
            shopDTO = gameDataService.GetItem(Type, UnlockLevel).Data;
            inventoryItem.ItemId = shopDTO.ID;
            try
            {
                if (gameDataService.isExsistItem(shopDTO.ID,getInventoryId).Success)
                {
                    var data = gameDataService.BuyItem(shopDTO.ID, inventoryItem, getLevel,decimal.Parse(lblMoney.Text));

                   getMoney= gameDataService.UpdateMoney(shopDTO.ID, GetAccountId).Data;
                    lblMoney.Text = getMoney.ToString();

                    MessageBox.Show(data.Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (InsufficientLevelException insufficientLevel)
            {
                MessageBox.Show(insufficientLevel.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExsistItemInvantoryException exsistItemInvantory)
            {
                MessageBox.Show(exsistItemInvantory.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch(NotEnoughMoneyException notEnoughMoney)
            {
                MessageBox.Show(notEnoughMoney.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception exception)
            {
                log.WriteLog("Admin", exception.Message);
            }
        }

        void GetItemForShop()
        {
            // GetItem
            // Ram1
            var Ram1 = gameDataService.GetItem("Ram", 1).Data;

            lblRamName1.Text = Ram1.Name;
            lblRamBrandName1.Text = Ram1.BrandRam;
            lblRamCapacity1.Text = Ram1.Capacity;
            lblUnitPriceRam1.Text = Ram1.UnitPrice.ToString();

            // Ran2
            var Ram2 = gameDataService.GetItem("Ram", 3).Data;

            lblRamName2.Text = Ram2.Name;
            lblRamBrandName2.Text = Ram2.BrandRam;
            lblRamCapacity2.Text = Ram2.Capacity;
            lblUnitPriceRam2.Text = Ram2.UnitPrice.ToString();

            // Ram3
            var Ram3 = gameDataService.GetItem("Ram", 5).Data;

            lblRamName3.Text = Ram3.Name;
            lblRamBrandName3.Text = Ram3.BrandRam;
            lblRamCapacity3.Text = Ram3.Capacity;
            lblUnitPriceRam3.Text = Ram3.UnitPrice.ToString();

            //Motherboard1

            var Motherboard1 = gameDataService.GetItem("Motherboard", 1).Data;

            lblMotherBoardName1.Text = Motherboard1.Name;
            lblMotherBoardChipset1.Text = Motherboard1.Chipset;
            lblMotherBoardBrand1.Text = Motherboard1.BrandMotherBoard;
            lblUnitPriceMotherboard1.Text = Motherboard1.UnitPrice.ToString();

            //Motherboard 2

            var Motherboard2 = gameDataService.GetItem("Motherboard", 3).Data;

            lblMotherBoardName2.Text = Motherboard2.Name;
            lblMotherBoardChipset2.Text = Motherboard2.Chipset;
            lblMotherBoardBrand2.Text = Motherboard2.BrandMotherBoard;
            lblUnitPriceMotherboard2.Text = Motherboard2.UnitPrice.ToString();


            // Motherboard 3
            var Motherboard3 = gameDataService.GetItem("Motherboard", 5).Data;

            lblMotherBoardName3.Text = Motherboard3.Name;
            lblMotherBoardChipset3.Text = Motherboard3.Chipset;
            lblMotherBoardBrand3.Text = Motherboard3.BrandMotherBoard;
            lblUnitPriceMotherboard3.Text = Motherboard3.UnitPrice.ToString();

            // Cpu 1

            var CPU1 = gameDataService.GetItem("Cpu", 1).Data;

            lblCPUName1.Text = CPU1.Name;
            lblBrandCpu1.Text = CPU1.BrandCpu;
            lblUnitPriceCpu1.Text = CPU1.UnitPrice.ToString();

            // Cpu 2

            var CPU2 = gameDataService.GetItem("Cpu", 3).Data;

            lblCPUName2.Text = CPU2.Name;
            lblBrandCpu2.Text = CPU2.BrandCpu;
            lblUnitPriceCpu2.Text = CPU2.UnitPrice.ToString();

            // Cpu 3

            var CPU3 = gameDataService.GetItem("Cpu", 5).Data;

            lblCPUName3.Text = CPU3.Name;
            lblBrandCpu3.Text = CPU3.BrandCpu;
            lblUnitPriceCpu3.Text = CPU3.UnitPrice.ToString();

            // Display 1

            var Display1 = gameDataService.GetItem("Display", 1).Data;

            lblDisplayName1.Text = Display1.Name;
            lblDisplayType1.Text = Display1.DisplayType;
            lblBrandDisplay1.Text = Display1.BrandDisplay;
            lblDisplayInc1.Text = Display1.Inc;
            lblUnitPriceDisplay1.Text = Display1.UnitPrice.ToString();

            // Display 2

            var Display2 = gameDataService.GetItem("Display", 3).Data;

            lblDisplayName2.Text = Display2.Name;
            lblDisplayType2.Text = Display2.DisplayType;
            lblBrandDisplay2.Text = Display2.BrandDisplay;
            lblDisplayInc2.Text = Display2.Inc;
            lblUnitPriceDisplay2.Text = Display2.UnitPrice.ToString();

            //Display 3

            var Display3 = gameDataService.GetItem("Display", 5).Data;

            lblDisplayName3.Text = Display3.Name;
            lblDisplayType3.Text = Display3.DisplayType;
            lblBrandDisplay3.Text = Display3.BrandDisplay;
            lblDisplayInc3.Text = Display3.Inc;
            lblUnitPriceDisplay3.Text = Display3.UnitPrice.ToString();

        }

        IGameDataService gameDataService;
        Log log = new Log();
        private void frmShopTR_Load(object sender, EventArgs e)
        {
            lblMoney.Text = getMoney.ToString();
            GetItemForShop();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            frmGameScreenTR frmGameScreen = new frmGameScreenTR();
            frmGameScreen.GetAccountId = GetAccountId;
            frmGameScreen.GetUsername= GetUsername;
            frmGameScreen.GetInventory = getInventoryId;
            frmGameScreen.Show();
            this.Close();
        }

        private void btnBuyCpu1_Click(object sender, EventArgs e)
        {
            BuyItem(shopDTO, "Cpu", 1);
        }

        private void btnBuyCpu2_Click(object sender, EventArgs e)
        {
            BuyItem(shopDTO, "Cpu", 3);
        }

        private void btnBuyCpu3_Click(object sender, EventArgs e)
        {
            BuyItem(shopDTO, "Cpu", 5);
        }

        private void btnBuyRam1_Click(object sender, EventArgs e)
        {
            BuyItem(shopDTO, "Ram", 1);
        }

        private void btnBuyRam2_Click(object sender, EventArgs e)
        {
            BuyItem(shopDTO, "Ram", 3);
        }

        private void btnBuyRam3_Click(object sender, EventArgs e)
        {
            BuyItem(shopDTO, "Ram", 5);
        }

        private void btnBuyMotherboard1_Click(object sender, EventArgs e)
        {
            BuyItem(shopDTO, "Motherboard", 1);
        }

        private void btnBuyMotherboard2_Click(object sender, EventArgs e)
        {
            BuyItem(shopDTO, "Motherboard", 3);
        }

        private void btnBuyMotherboard3_Click(object sender, EventArgs e)
        {
            BuyItem(shopDTO, "Motherboard", 5);
        }

        private void btnBuyDisplay1_Click(object sender, EventArgs e)
        {
            BuyItem(shopDTO, "Display", 1);
        }

        private void btnBuyDisplay2_Click(object sender, EventArgs e)
        {
            BuyItem(shopDTO, "Display", 3);
        }

        private void btnBuyDisplay3_Click(object sender, EventArgs e)
        {
            BuyItem(shopDTO, "Display", 5);
        }
    }
}
