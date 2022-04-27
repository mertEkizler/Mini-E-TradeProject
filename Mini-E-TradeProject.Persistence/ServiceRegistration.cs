using Microsoft.Extensions.DependencyInjection;
using Mini_E_TradeProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Mini_E_TradeProject.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETradeDBContext>
                (
                    options => options.UseSqlServer(Configuration.ConnectionString)
                );
        }
    }
}