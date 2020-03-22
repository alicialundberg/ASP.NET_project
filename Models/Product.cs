using System;
using System.ComponentModel.DataAnnotations;

namespace StockSystem.Models
{
    public class Product
    {
         //Properties
        public int ProductId { get; set; } // Primary Key
        public string ProductName { get; set; }
        public double ProductSize { get; set; }
        public double ProductPrice { get; set; }
        public int StockQuantity { get; set; }
        
        public int BrandId { get; set; } // Foreign Key

        public Brand Brand { get; set; } // Get Brand Model

    }
}
