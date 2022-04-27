using Microsoft.EntityFrameworkCore;
using Mini_E_TradeProject.Domain.Entities.Concrete;

namespace Mini_E_TradeProject.Persistence.Contexts
{
    public class ETradeDBContext : DbContext
    {
        public ETradeDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}