using Microsoft.EntityFrameworkCore;
using NewShopDemo.Models;

namespace NewShopDemo.Data
{
    public interface IApplicationDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public int SaveChanges();
    }
}