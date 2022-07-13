
using Microsoft.EntityFrameworkCore;
using WebApp_EF_Customer.Model;

namespace WebApp_EF_Customer.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }
    }
}
