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
    public interface IMyProductSevice
    {
        IDataResult<List<InventoryDTO>> GetYourItems(string Type, int inventoryId);
        IDataResult<List<Color>> GetPhoneColors();
        IDataResult<List<InventoryDTO>> ShowInventory();
        IResult CreatePhone(MyProduct myProduct);
        IDataResult<bool> CheckMissingPart(string ram, string cpu, string motherboard, string display);
        IDataResult<decimal> GetUnitPrice(decimal ItemId);
        IDataResult <MyProduct> GetProductById (string productName);
        IDataResult<bool> IsExistProductName(string name);
        IResult UpdateProduct(MyProduct product);
        IDataResult<GameData> GetGameDataById(int gameDataId);
        IResult levelsytem(int gameDataId);
        IDataResult<List<MyPoductDTO>> ListProduct();
    }
}
