using Ninject.Modules;
using ShopApp.BLL.Interfaces;
using ShopApp.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsHomeWork_3.Util
{
    public class ServicesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductsService>().To<ProductsService>();
            Bind<ICategoriesService>().To<CategoriesService>();
            Bind<IShopsService>().To<ShopsService>();
        }
    }
}
