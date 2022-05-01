using Core.DataAccsess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfAccountDal : EntityRepositoryBase<Account, MyCompanyContext>, IAccountDal
    {
        public bool IsThereSavedData(int gameData)
        {
            using (var context = new MyCompanyContext())
            {
                var data = context.GameDatas.Where(x => x.AccountID == gameData && x.IsActiveSave==true).ToList();
                if (data.Count >= 1)
                {
                    return data.Any();
                }
                else
                    return false;
            }
        }

        public bool IsExistEmail(string email)
        {
            using (var context = new MyCompanyContext())
            {
                var data = context.Accounts.Where(x => x.Email == email).Select(y => y.Email).ToList();
                if (data.Count >= 1)
                {
                    return data.Any();
                }
                return false;
            }

        }

        public bool LoginGame(string username, string password)
        {
            using (var context = new MyCompanyContext())
            {
                return context.Accounts.Any(x => x.UserName == username && x.Password == password && x.IsActiveAccount == true);
            }
        }

        public void MakeActiveData(string email)
        {
            using (var context = new MyCompanyContext())
            {
                var getaAccount = Get(x => x.Email == email);
                getaAccount.IsActiveAccount = true;
                context.Update(getaAccount);
                context.SaveChanges();
            }
        }

        public bool DeleteAccount(int Id)
        {
            using (var context = new MyCompanyContext())
            {
                var getAccount = Get(x => x.Id == Id);

                if (!IsThereSavedData(getAccount.Id))
                {
                    deleteMyProduct(Id);
                    deleteGamaData(Id);
                    DeleteInventory(Id);
                    Delete(getAccount);
                    context.SaveChanges();
                    return true;
                }
                else
                    return false;

            }

        }

        public int GetInventoryId(int accountId)
        {
            using (var context = new MyCompanyContext())
            {
                return context.Inventories.Where(x => x.AccountId == accountId).Select(y => y.Id).FirstOrDefault();
            }
        }

        public void DeleteInventory(int accountId)
        {
            using (var context = new MyCompanyContext())
            {
                var data = GetInventoryId(accountId);
                var deleteData = context.InventoryItems.Where(x => x.InventoryId == data).ToList();
                foreach (var item in deleteData)
                {
                    context.InventoryItems.Remove(item);
                }
                context.SaveChanges();

            }
        }

        public void deleteGamaData(int accountId)
        {
            using (var context = new MyCompanyContext())
            {
                var deleteData = context.GameDatas.Where(x => x.AccountID == accountId).ToList();
                foreach (var item in deleteData)
                {
                    context.GameDatas.Remove(item);
                }
                context.SaveChanges();
            }
        }

        public void deleteMyProduct(int gamaDataId)
        {
            using (var context = new MyCompanyContext())
            {
                var getGamaData = context.GameDatas.Where(x => x.AccountID == gamaDataId).Select(y => y.Id).FirstOrDefault();
                var getMyProduct = context.MyProducts.Where(x => x.GameDataId == getGamaData).ToList();

                foreach (var item in getMyProduct)
                {
                    context.MyProducts.Remove(item);
                }
                context.SaveChanges();
            }
        }
    }
}