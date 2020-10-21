using Gluh.TechnicalTest.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gluh.TechnicalTest.Data
{
    public class Context : DbContext
    {
        // Constructors

        public Context(DbContextOptions<Context> options) : base(options) {}

        // Public 
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Product> Products { get; set; }

      

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<PurchaseRequirement> PurchaseRequirements { get; set; }

    }
}