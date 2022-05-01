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
    public interface IMyProductDal:IEntityRepository<MyProduct>
    {
        List<InventoryDTO> GetInventory();
        List<InventoryDTO> GetYourItems(string Type, int inventoryId);
        List<Color> GetPhoneColors();
        decimal GetUnitPrice (decimal ItemId);
        bool IsExistProduct(string name);
        List<MyPoductDTO> GetPoducts();
        GameData GetGameDataById(int gameDataId);
        void LvlSystem(int gameDataId);
    }
}
