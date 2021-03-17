using ShopApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Product,int> ProductsRepository { get;  }
        IRepository<Category,int> CategoriesRepository { get; }
        IRepository<Shop,int> ShopsRepository { get; }

        void Save();
    }
}
