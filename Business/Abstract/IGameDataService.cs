using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGameDataService
    {
        IResult StartNewGame(GameData gameData);
        IDataResult<bool> IsExxsistGameData(int Id);
        IResult MakeDsableOldData(int AccountId);
        IDataResult<GameData> GetGameDataById(int Id);
        IDataResult<ShopDTO> GetItem(string itemTypeName, byte unlocklevel);
        IResult BuyItem(int itemId, InventoryItem inventoryItem, byte level, decimal money);
        IDataResult<bool> LevelControl(byte level, int itemId);
        IDataResult<bool> isExsistItem(int itemId, int inventoryId);
        IDataResult<decimal> UpdateMoney(int itemId, int accountId);
        IDataResult<bool> MoneyCheck(int itemId, decimal money);
        IResult UpdateData(GameData gameData);
        IResult MakePassiveSave(int gameDataId);

    }
}
