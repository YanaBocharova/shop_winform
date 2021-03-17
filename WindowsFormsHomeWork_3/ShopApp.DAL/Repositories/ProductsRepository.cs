using ShopApp.DAL.EF;
using ShopApp.DAL.Entities;
using ShopApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ShopApp.DAL.Repositories
{
    class ProductsRepository : BaseRepository<Product, int>
    {
        public ProductsRepository(ShopContext context) : base(context)
        {
        }
        public override IEnumerable<Product> GetAll()
        {
            return table.Include(c => c.Category).Include(c => c.Shop).ToList();
        }
        public override IEnumerable<Product> GetAll(Func<Product, bool> predicate)
        {
            return table.Include(c => c.Category).Include(c => c.Shop).Where(predicate).ToList();
        }

        public override void Update(Product item)
        {
            var srch = Get(item.Id);
            srch.Copy(item);
            context.SaveChanges();
        }
    }
}
