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
    public class CategoriesRepository : BaseRepository<Category, int>
    {
        public CategoriesRepository(ShopContext context) : base(context)
        {
        }
        public override IEnumerable<Category> GetAll()
        {
            return table.Include(c => c.Products).ToList();
        }
        public override IEnumerable<Category> GetAll(Func<Category, bool> predicate)
        {
            return table.Include(c => c.Products).Where(predicate).ToList();
        }
        public override void Update(Category item)
        {
            var srch = Get(item.Id);
            srch.Copy(item);
            context.SaveChanges();
        }
    }
}
