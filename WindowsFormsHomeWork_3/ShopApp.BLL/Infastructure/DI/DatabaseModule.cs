using Ninject.Modules;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BLL.Infastructure.DI
{
    public class DatabaseModule : NinjectModule
    {
        private string connectionString;
        public DatabaseModule(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public override void Load()
        {
            //регистрация зависимостей
            Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
