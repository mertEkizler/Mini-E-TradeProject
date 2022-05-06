using Microsoft.EntityFrameworkCore;
using Mini_E_TradeProject.Domain.Entities.Common;
using Mini_E_TradeProject.Domain.Entities.Concrete;

namespace Mini_E_TradeProject.Persistence.Contexts
{
    public class ETradeDBContext : DbContext
    {
        public ETradeDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}