using Microsoft.EntityFrameworkCore;
using CommercialChain.Data.Entities;

namespace CommercialChain.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Product> Chains { get; set; }
    }
}
