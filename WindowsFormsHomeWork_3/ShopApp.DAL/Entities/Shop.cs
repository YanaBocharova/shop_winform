using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Entities
{
    public class Shop: BaseEntity<int>
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }

        public ICollection<Product> Products { get; set; }

        public void Copy(Shop from)
        {
            Name = from.Name;
            Adress = from.Adress;
            Telephone = from.Telephone;
        }
    }
}
