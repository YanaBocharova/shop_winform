using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BLL.DTO
{
    public class ShopDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }
        public IEnumerable<ProductDTO> Products { get; set; }
    }
}
