using ShopApp.DAL.EF;
using ShopApp.DAL.Entities;
using ShopApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ShopContext context;
        private  ProductsRepository _productsRepository;
        private  CategoriesRepository _categoriesRepository;
        private  ShopsRepository _shopsRepository;

        public IRepository<Product, int> ProductsRepository =>
          _productsRepository ?? (_productsRepository = new ProductsRepository(context));
        public IRepository<Category, int> CategoriesRepository =>
            _categoriesRepository ?? (_categoriesRepository = new CategoriesRepository(context));
        public IRepository<Shop, int> ShopsRepository => 
            _shopsRepository??(_shopsRepository=new ShopsRepository(context));

        private bool disposed = false;

        public UnitOfWork(string connectionString)
        {
            context = new ShopContext(connectionString);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    context.Dispose();
                }
                disposing = true;
            }
        }

        public void Save() => context.SaveChanges();
      
    }
}
