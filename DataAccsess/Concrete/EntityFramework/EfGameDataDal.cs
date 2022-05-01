using Core.DataAccsess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfGameDataDal : EntityRepositoryBase<GameData, MyCompanyContext>, IGameDataDal
    {
        public void BuyItem(InventoryItem inventoryItem)
        {
            using (var context = new MyCompanyContext())
            {
                inventoryItem.Id = 0;
                context.InventoryItems.Add(inventoryItem);
                context.SaveChanges();

            }
        }

        public bool DataControl(int AccountId)
        {
            using (var context = new MyCompanyContext())
            {
                var data = context.GameDatas.Where(x => x.AccountID == AccountId && x.IsActiveSave == true).Select(y => y.Id).ToList();
                if (data.Count >= 1)
                {
                    return true;
                }
                return false;
            }

        }

        public ShopDTO GetItem(string itemTypeName, byte unlocklevel)
        {
            var shopDatas = GetShopDatas();
            return shopDatas.Where(x => x.ItemTypeName == itemTypeName && x.UnlockLevel == unlocklevel).FirstOrDefault();

        }


        public List<ShopDTO> GetShopDatas()
        {
            using (var context = new MyCompanyContext())
            {
                var data = (from item in context.Items
                            join cpu in context.Cpus
                            on item.Id equals cpu.ItemId into addCpu
                            from cpu in addCpu.DefaultIfEmpty()
                            join motherboard in context.Motherboards
                            on item.Id equals motherboard.ItemId into addMotherboard
                            from motherboard in addMotherboard.DefaultIfEmpty()
                            join display in context.Displays
                            on item.Id equals display.ItemId into addDisplay
                            from display in addDisplay.DefaultIfEmpty()
                            join ram in context.Rams
                            on item.Id equals ram.ItemId into addRam
                            from ram in addRam.DefaultIfEmpty()
                            join itemType in context.ItemTypes
                            on item.ItemTypeId equals itemType.Id into addItemType
                            from itemType in addItemType.DefaultIfEmpty()
                            select new ShopDTO
                            {
                                ID = item.Id,
                                Name = item.ItemName,
                                UnitPrice = item.UnitPrice,
                                UnlockLevel = item.Unlocklevel,
                                ItemTypeName = itemType.ItemName,
                                BrandCpu = cpu.Brand,
                                BrandMotherBoard = motherboard.Brand,
                                BrandDisplay = display.Brand,
                                BrandRam = ram.Brand,
                                Capacity = ram.Capacity,
                                Chipset = motherboard.Chipset,
                                DisplayType = display.DisplayType,
                                Inc = display.Inc
                            });
                return data.ToList();


            }
        }

        public bool isExsistItem(int itemId, int inventoryId)
        {
            using (var context = new MyCompanyContext())
            {
                var itemList = context.InventoryItems.Where(a => a.InventoryId == inventoryId).ToList();
                if (itemList.Count(x => x.ItemId == itemId) >= 1)
                {
                    return false;
                }
                return true;
            }
        }

        public bool LevelControl(byte level, int itemId)
        {
            using (var context = new MyCompanyContext())
            {
                var getItem = context.Items.Where(x => x.Id == itemId).FirstOrDefault();
                if (getItem.Unlocklevel == level)
                {
                    return true;
                }
                return false;
            }
        }

        public void MakePassiveSave(int gameDataId)
        {
            using (var context=new MyCompanyContext())
            {
               var data= context.GameDatas.Where(x => x.Id == gameDataId && x.IsActiveSave == true).FirstOrDefault();
                data.IsActiveSave = false;
                context.Update(data);
                context.SaveChanges();
            }
        }

        public bool MoneyCheck(int itemId, decimal money)
        {
            using (var context = new MyCompanyContext())
            {
                var getUnitPrice = context.Items.Where(x => x.Id == itemId).Select(y => y.UnitPrice).FirstOrDefault();
                if (getUnitPrice > money || money < 0)
                {
                    return false;
                }
                return true;
            }

        }

        public void PassiveOldData(int Id)
        {
            using (var context = new MyCompanyContext())
            {
                var getGameData = Get(x => x.AccountID == Id && x.IsActiveSave == true);
                getGameData.IsActiveSave = false;
                context.Update(getGameData);
                context.SaveChanges();
            }
        }

        public decimal UpdateMoney(int itemId, int getAccountId)
        {
            using (var context = new MyCompanyContext())
            {
                var getUnitPrice = context.Items.Where(x => x.Id == itemId).Select(y => y.UnitPrice).FirstOrDefault();

                var getGameData = context.GameDatas.Where(x => x.AccountID == getAccountId && x.IsActiveSave == true).FirstOrDefault();
                var monay = getGameData.Money;
                getGameData.Money -= getUnitPrice;
                context.GameDatas.Update(getGameData);
                context.SaveChanges();
                return getGameData.Money;
            }
        }
    }
}
