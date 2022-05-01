using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAccountService
    {
        IDataResult<bool> LoginGane(string username, string password);
        IResult CheckEmailSymbol(string email);
        IDataResult<bool> IsAnyEmailValid(string email);
        IDataResult<bool> CheckPassword (string password, string rePassword);
        IResult AddAccount(Account account);
        IResult SendEmail(string mail, int code);
        IDataResult<bool> ActivationAccount (ref int code, string activation);
        IResult MakeActiveData(string email);
        IDataResult<bool> DeleteAccount(int Id);
        IDataResult<bool> IsThereSavedData(int gameData);
        IDataResult<Account> GetAccountID(string username, string password);
        IDataResult<int> GetInventoryId(int accountId);
        IResult DeleteInventory(int accountId);
    }
}
