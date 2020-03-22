using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockSystem.Models
{
    public class Brand
    {
         //Properties
        public int BrandId { get; set; } // Primary Key
        public string BrandName { get; set; }

        public List<Product> Products { get; set; }
    
    }
}
