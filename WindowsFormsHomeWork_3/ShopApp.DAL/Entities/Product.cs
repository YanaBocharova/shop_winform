using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Entities
{
    public class Product: BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public  decimal Price { get; set; }
        public Shop Shop { get; set; }
        public int? ShopId { get; set; }
        public Category Category { get; set; }
        public int? CategoryId { get; set; }

        public void Copy(Product from)
        {
            Name = from.Name;
            Description = from.Description;
            Price = from.Price;
            CategoryId = from.CategoryId;
        }
    } 
}
