using ShopApp.BLL.DTO;
using ShopApp.BLL.Interfaces;
using ShopApp.DAL.Entities;
using ShopApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BLL.Services
{
    public class ProductsService :BaseService, IProductsService
    {
        public ProductsService(IUnitOfWork uwo) : base(uwo) { }

        public void Dispose() => db.Dispose();

        public ProductDTO GetProduct(int id)
        {
            var prod = db.ProductsRepository.Get(id);

            return mapper.Map<ProductDTO>(prod);
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            var products = db.ProductsRepository.GetAll();
            return mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public void UpdateProductDTO(ProductDTO item)
        {
            var prod = mapper.Map<Product>(item);
             db.ProductsRepository.Update(prod);
            db.Save();

        }
    }
}
