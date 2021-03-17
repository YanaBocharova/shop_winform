﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BLL.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string  Name { get; set; }

        public IEnumerable<ProductDTO> Products { get; set; }
    }
}
