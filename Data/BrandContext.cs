using System;
using StockSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace StockSystem.Data 
{
    public class BrandContext : DbContext 
    {
        public BrandContext(DbContextOptions<BrandContext> options) : base(options) 
        {
        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}