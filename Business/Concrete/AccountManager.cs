using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Email;
using Core.Utilities.Exceptions;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountManager : IAccountService
    {
        IAccountDal _accountDal;

        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }

        public IDataResult<bool> LoginGane(string username, string password)
        {
            if (_accountDal.LoginGame(username, password))
            {
                return new SuccessDataResult<bool>(_accountDal.LoginGame(username, password));
            }
            else
            {
                return new ErrorDataResult<bool>(MessagesTR.ValildLogin);
            }
        }

        public IResult CheckEmailSymbol(string email)
        {
            if (!(email.Contains("@") && email.EndsWith(".com")))
            {
                throw new EMailSymbolMissingException(MessagesTR.ValidEmailAddress);
            }
            else
                return new SuccessResult();
        }

        public IResult AddAccount(Account account)
        {
            IResult result = BusinessRules.Run(CheckEmailSymbol(account.Email));

            if (result != null)
            {
                return result;
            }

            _accountDal.Add(account);
            return new SuccessResult(MessagesTR.SuccessRegistration);
        }

        public IDataResult<bool> IsAnyEmailValid(string email)
            {

            if (_accountDal.IsExistEmail(email))
            {
                throw new EMailSymbolMissingException(MessagesTR.ValidEmailAddress);
            }
            else
            {
                return new SuccessDataResult<bool>();
            }
        }

        public IDataResult<bool> CheckPassword(string password, string rePassword)
        {
            if ((password != rePassword))
            {
                return new ErrorDataResult<bool>(MessagesTR.PasswordDoesNotMatch);
            }
            else
               return new SuccessDataResult<bool>();
        }

       public IResult SendEmail(string mail, int code)
        {
            SendEmail email = new SendEmail();
            email.send(mail, ref code);
            return new SuccessResult();
        }

        public IDataResult<bool> ActivationAccount(ref int code, string activation)
        {
            if (code == int.Parse(activation))
            {
                return new SuccessDataResult<bool>(MessagesTR.SuccessActivation);
            }
            return new ErrorDataResult<bool>(MessagesTR.ErrorActivation);
        }

        public IResult MakeActiveData(string email)
        {
            _accountDal.MakeActiveData(email);
            return new SuccessResult();
        }

        public IDataResult<bool> DeleteAccount(int Id)
        {
            if (_accountDal.DeleteAccount(Id))
            {
                return new SuccessDataResult<bool>(MessagesTR.DeletedAccount);
            }
            else
                return new SuccessDataResult<bool>(MessagesTR.ThereIsSavedGameData);

        }

        public IDataResult<bool> IsThereSavedData(int gameData)
        {
            return new SuccessDataResult<bool>(_accountDal.IsThereSavedData(gameData));
        }

        public IDataResult<Account> GetAccountID(string username, string password)
        {
            return new SuccessDataResult<Account>(_accountDal.Get(x => x.UserName == username && x.Password == password)); 
        }

        public IDataResult<int> GetInventoryId(int accountId)
        {
           return new SuccessDataResult<int>(_accountDal.GetInventoryId(accountId));
        }

        public IResult DeleteInventory(int accountId)
        {
            _accountDal.DeleteInventory(accountId);
            return new SuccessResult();
        }
    }
}
