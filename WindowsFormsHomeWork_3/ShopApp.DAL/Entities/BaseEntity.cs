using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Entities
{
    public class BaseEntity<T>
        where T:struct
    {
        public int Id { get; set; }
    }
}
