using Business.Abstract;
using Business.Concrete;
using DataAccsess.Abstract;
using DataAccsess.Concrete.EntityFramework;
using Microsoft.Extensions.Logging;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyReolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IAccountService>().To<AccountManager>().InSingletonScope();
            Bind<IGameDataService>().To<GameDataManager>().InSingletonScope();
            Bind<IMyProductSevice>().To<MyProductManager>().InSingletonScope();

            Bind<IAccountDal>().To<EfAccountDal>().InSingletonScope();
            Bind<IGameDataDal>().To<EfGameDataDal>().InSingletonScope();
            Bind<IMyProductDal>().To<EfMyProductDal>().InSingletonScope();
        }
    }
}
