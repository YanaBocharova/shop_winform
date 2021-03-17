using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BLL.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ShopDTO Shop { get; set; }
        public int? ShopId { get; set; }
        public CategoryDTO Category { get; set; }
        public int? CategoryId { get; set; }
        public override string ToString() => $"{Name,10} \tCategory:{Category.Name} ";
        
    }
}
