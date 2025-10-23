using Microsoft.EntityFrameworkCore;
using NewShopDemo.Models;

namespace NewShopDemo.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options: options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=NewShopDemo;User=SA;Password=Password123!;TrustServerCertificate=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connectionString: connectionString);
        }
    }
}