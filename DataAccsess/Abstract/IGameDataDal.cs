using Core.DataAccsess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Abstract
{
    public interface IGameDataDal:IEntityRepository<GameData>
    {
        bool DataControl(int AccountId);
        void PassiveOldData(int Id);
        List<ShopDTO> GetShopDatas();
        ShopDTO GetItem(string itemTypeName, byte unlocklevel);
        void BuyItem (InventoryItem inventoryItem);
        bool LevelControl(byte level, int itemId);
        decimal UpdateMoney(int itemId,int getAccountId);
        bool isExsistItem (int itemId, int inventoryId);
        bool MoneyCheck(int itemId,decimal money);
        void MakePassiveSave(int gameDataId);

    }
}
