using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Exceptions;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GameDataManager:IGameDataService
    {
        IGameDataDal _gameDataDal;

        public GameDataManager(IGameDataDal gameDataDal)
        {
            _gameDataDal = gameDataDal;
        }

        public IResult BuyItem(int itemId, InventoryItem inventoryItem, byte level, decimal money)
        {
            if ((LevelControl(level, itemId).Success) && (MoneyCheck(itemId,money).Success))
            {
                _gameDataDal.BuyItem(inventoryItem);
                return new SuccessResult(MessagesTR.BuyItemMassage);
            }
            return new ErrorResult();
         
        }

        public IDataResult<GameData> GetGameDataById(int Id)
        {
            return new SuccessDataResult<GameData>(_gameDataDal.Get(x=> x.AccountID==Id && x.IsActiveSave==true));
        }

        public IDataResult<ShopDTO> GetItem(string itemTypeName, byte unlocklevel)
        {
            return new SuccessDataResult<ShopDTO>(_gameDataDal.GetItem(itemTypeName, unlocklevel));
        }

        public IDataResult<bool> isExsistItem(int itemId, int inventoryId)
        {
            if (!(_gameDataDal.isExsistItem(itemId,inventoryId)))
            {
                throw new ExsistItemInvantoryException(MessagesTR.YouHaveItemsInInventory);
            }
            return new SuccessDataResult<bool>();
        }

        public IDataResult<decimal> UpdateMoney(int itemId, int accountId)
        {
          return new SuccessDataResult<decimal>(_gameDataDal.UpdateMoney(itemId, accountId));
        }

        public IDataResult<bool> IsExxsistGameData(int Id)
        {
            if (_gameDataDal.DataControl(Id))
            {
                return new SuccessDataResult<bool>();
            }
            return new ErrorDataResult<bool>();
        }

        public IDataResult<bool> LevelControl(byte level, int itemId)
        {
            if (_gameDataDal.LevelControl(level,itemId))
            {
               return new SuccessDataResult<bool>();
            }
            throw new InsufficientLevelException(MessagesTR.InsufficientLevel);
        }

        public IResult MakeDsableOldData(int GameDataId)
        {
            _gameDataDal.PassiveOldData(GameDataId);
            return new SuccessResult();
        }

        public IResult StartNewGame(GameData gameData)
        {
           _gameDataDal.Add(gameData);
            return new SuccessResult(MessagesTR.NewGameMessage);
        }

       public IDataResult<bool> MoneyCheck(int itemId, decimal money)
        {
            if (_gameDataDal.MoneyCheck(itemId, money))
            {
                return new SuccessDataResult<bool>();
            }
            else
                throw new NotEnoughMoneyException(MessagesTR.NotEnoughMoney);
        }

        public IResult UpdateData(GameData gameData)
        {
            _gameDataDal.Update(gameData);
            return new SuccessResult();
        }

        public IResult MakePassiveSave(int gameDataId)
        {
            _gameDataDal.MakePassiveSave(gameDataId);
            return new SuccessResult();
        }
    }
}
