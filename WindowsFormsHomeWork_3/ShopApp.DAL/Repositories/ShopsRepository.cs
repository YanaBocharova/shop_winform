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
    public class ShopsRepository : BaseRepository<Shop, int>
    {
        public ShopsRepository(ShopContext context) : base(context)
        {
        }
        public override IEnumerable<Shop> GetAll(Func<Shop, bool> predicate)
        {
            return table.Include(c => c.Products).Where(predicate).ToList();
        }
        public override IEnumerable<Shop> GetAll()
        {
            return table.Include(c => c.Products).ToList();
        }
        public override void Update(Shop item)
        {
            var srch = Get(item.Id);
            srch.Copy(item);
            context.SaveChanges();
        }
    }
}
