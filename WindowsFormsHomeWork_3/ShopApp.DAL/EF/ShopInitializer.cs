using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ShopApp.DAL.Entities;

namespace ShopApp.DAL.EF
{
    public class ShopInitializer:DropCreateDatabaseAlways<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            base.Seed(context);

            var cat1 = new Category { Name = "Monitor" };
            var cat2 = new Category { Name = "Mouse" };
            var cat3 = new Category { Name = "CPU" };

            var shop1 = new Shop
            {
                Name = "Comfy",
                Adress = "Dnipro 45",
                Telephone = "+39094834374",
            };

            var prod1 = new Product
            {
                Category = cat1,
                Name = "Multy monitor 1",
                Price = 10000,
                Description = "Description monitor",
                Shop=shop1
            };
            var prod2 = new Product
            {
                Category = cat1,
                Name = "Multy monitor 2",
                Price = 4000,
                Description = "Description monitor 2",
                Shop = shop1
            };
            var prod3 = new Product
            {
                Category = cat2,
                Name = "Mouse 1",
                Price = 500,
                Description = "Description mouse",
                Shop = shop1
            };

            var prod4 = new Product
            {
                Category = cat3,
                Name = "CPU 1",
                Price = 35000,
                Description = "Description CPU",
                Shop = shop1
            };


            context.Products.AddRange(new Product[] { prod1, prod2, prod3, prod4 });
            context.SaveChanges();

        }
    }
}
