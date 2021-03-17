using Microsoft.IdentityModel.Protocols;
using ShopApp.BLL.Interfaces;
using ShopApp.BLL.Services;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace ShopApp.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string connection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            IUnitOfWork uow = new UnitOfWork(connection);

            IProductsService productsService = new ProductsService(uow);
            var prod = productsService.GetProducts();

            foreach (var item in prod)
            {
                Console.WriteLine($"{item.Name} {item.Price}  {item.Category.Name}");
            }


            var prod1 = productsService.GetProduct(1);
            
            Console.WriteLine($"{prod1.Name} {prod1.Price} {prod1.Category.Name}");

            Console.Read();
        }
    }
}
