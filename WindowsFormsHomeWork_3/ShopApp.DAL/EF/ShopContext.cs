using ShopApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.EF
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Shop> Shops{ get; set; }

        static ShopContext()
        {
            Database.SetInitializer(new ShopInitializer());
        }
        public ShopContext(string connection)
            :base(connection)
        {

        }
    }
}
