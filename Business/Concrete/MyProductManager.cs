using Business.Abstract;
using Business.Constants;
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
    public class MyProductManager : IMyProductSevice
    {
        IMyProductDal _myProductDal;
        public MyProductManager(IMyProductDal myProductDal)
        {
            _myProductDal = myProductDal;
        }

        public IDataResult<bool> CheckMissingPart(string ram, string cpu, string motherboard, string display)
        {
            if (string.IsNullOrEmpty(ram) || string.IsNullOrEmpty(cpu) || string.IsNullOrEmpty(motherboard) || string.IsNullOrEmpty(display))
            {
                return new ErrorDataResult<bool>(MessagesTR.YourHaveNoItem);
            }
            return new SuccessDataResult<bool>();
        }

        public IResult CreatePhone(MyProduct myProduct)
        {

            _myProductDal.Add(myProduct);
            return new SuccessResult(MessagesTR.SuccessGeneratePhone);
        }

        public IDataResult<GameData> GetGameDataById(int gameDataId)
        {
            return new SuccessDataResult<GameData>(_myProductDal.GetGameDataById(gameDataId));
        }

        public IDataResult<List<Color>> GetPhoneColors()
        {
            return new SuccessDataResult<List<Color>>(_myProductDal.GetPhoneColors());
        }

        public IDataResult<MyProduct> GetProductById(string productName)
        {
            return new SuccessDataResult<MyProduct>(_myProductDal.Get(x => x.ProductName == productName));
        }

        public IDataResult<decimal> GetUnitPrice(decimal ItemId)
        {
            return new SuccessDataResult<decimal>(_myProductDal.GetUnitPrice(ItemId));
        }

        public IDataResult<List<InventoryDTO>> GetYourItems(string Type, int inventoryId)
        {
            return new SuccessDataResult<List<InventoryDTO>>(_myProductDal.GetYourItems(Type, inventoryId));
        }

        public IDataResult<bool> IsExistProductName(string name)
        {
            if (_myProductDal.IsExistProduct(name))
            {
                throw new ProductNameAvailableException(MessagesTR.ProductNameAvailable);
            }
            return new SuccessDataResult<bool>();
        }

        public IResult levelsytem(int gameDataId)
        {
            _myProductDal.LvlSystem(gameDataId);
            return new SuccessResult();
        }

        public IDataResult<List<MyPoductDTO>> ListProduct()
        {
            return new SuccessDataResult<List<MyPoductDTO>>(_myProductDal.GetPoducts());
        }

        public IDataResult<List<InventoryDTO>> ShowInventory()
        {
            return new SuccessDataResult<List<InventoryDTO>>(_myProductDal.GetInventory());
        }

        public IResult UpdateProduct(MyProduct product)
        {
            _myProductDal.Update(product);
            return new SuccessResult();
        }
    }
}
