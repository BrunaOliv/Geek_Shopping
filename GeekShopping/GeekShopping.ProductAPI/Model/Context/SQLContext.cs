using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext(){}
        public SQLContext(DbContextOptions<SQLContext> options) : base(options){}
        
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=geek_shopping_product_api;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=true");
            }

        }
    }
}
