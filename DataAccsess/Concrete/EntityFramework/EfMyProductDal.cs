using Core.DataAccsess.EntityFramework;
using DataAccsess.Abstract;
using DataAccsess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfMyProductDal : EntityRepositoryBase<MyProduct, MyCompanyContext>, IMyProductDal
    {
        public GameData GetGameDataById(int gameDataId)
        {
            using (var context = new MyCompanyContext())
            {
                return context.GameDatas.Where(x => x.Id == gameDataId).FirstOrDefault();
            }
        }

        public List<InventoryDTO> GetInventory()
        {
            using (var context = new MyCompanyContext())
            {
                var inventoryList = (from item in context.Items
                                     join inventory in context.InventoryItems on item.Id equals inventory.ItemId
                                     join itemType in context.ItemTypes on item.ItemTypeId equals itemType.Id
                                     select new InventoryDTO
                                     {
                                         Id = item.Id,
                                         ItemName = item.ItemName,
                                         ItemType = itemType.ItemName,
                                         InventoryId = inventory.InventoryId,
                                         UnitPrice = item.UnitPrice
                                     }).ToList();
                return inventoryList;
            }
        }

        public List<Color> GetPhoneColors()
        {
            using (var context = new MyCompanyContext())
            {
                return context.Colors.ToList();
            }
        }

        public List<MyPoductDTO> GetPoducts()
        {
            using (var context = new MyCompanyContext())
            {
                return context.MyProducts.Join(context.Colors, 
                    product=>product.ProductColorId, color=> color.Id,(product,color)=> new MyPoductDTO
                    {
                        Id=product.Id,
                        ProductName=product.ProductName,
                        AveragePoint=product.AveragePoint,
                        BestProduct=product.BestProduct,
                        ColorName=color.ColorName,
                        ProductSalesGain= product.ProductSalesGain
                    }).ToList();
            }
        }

        public decimal GetUnitPrice(decimal ItemId)
        {
            var getPrice = GetInventory().Where(x => x.Id == ItemId).Select(y => y.UnitPrice).FirstOrDefault();
            return getPrice;
        }

        public List<InventoryDTO> GetYourItems(string Type, int inventoryId)
        {

            var inventoryList = GetInventory().Where(x => x.InventoryId == inventoryId);
            var data = inventoryList.Where(x => x.ItemType == Type).Select(x => new InventoryDTO
            {
                ItemName = x.ItemName,
                Id = x.Id,
            }).ToList();
            return data;
        }

        public bool IsExistProduct(string name)
        {
            using (var context = new MyCompanyContext())
            {
                var data = context.MyProducts.Where(x => x.ProductName == name).Select(y => y.ProductName).ToList();
                if (data.Count >= 1)
                {
                    return data.Any();
                }
                return false;
            }
        }

        public void LvlSystem(int gameDataId)
        {
            var data = GetGameDataById(gameDataId);
            if (data.XpLimit==data.Xp)
            {
                data.Level++;
                data.XpLimit *= 2;
            }
        }
    }
}
