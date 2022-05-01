using Core.DataAccsess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Abstract
{
    public interface IAccountDal: IEntityRepository<Account>
    {
        bool LoginGame(string username, string password);
        bool IsExistEmail(string email);
        void MakeActiveData(string email);
        bool DeleteAccount(int Id);
        bool IsThereSavedData(int gameData);
        int GetInventoryId(int accountId);
        void DeleteInventory(int accountId);
        void deleteGamaData (int accountId);
        void deleteMyProduct(int gamaDataId);
    }
}
