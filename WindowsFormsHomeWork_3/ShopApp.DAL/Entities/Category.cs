using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Entities
{
    public class Category: BaseEntity<int>
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public void Copy(Category from)
        {
            Name = from.Name;
        }
    }
}
