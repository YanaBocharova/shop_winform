using ShopApp.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BLL.Interfaces
{
    public interface IProductsService:IDisposable
    {
        ProductDTO GetProduct(int id);
        IEnumerable<ProductDTO> GetProducts();
        void UpdateProductDTO(ProductDTO item);
    }
}
