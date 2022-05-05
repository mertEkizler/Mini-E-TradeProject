using Microsoft.Extensions.DependencyInjection;
using Mini_E_TradeProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Mini_E_TradeProject.Application.Repositories;
using Mini_E_TradeProject.Persistence.Repositories;

namespace Mini_E_TradeProject.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETradeDBContext>
                (
                    options => options.UseSqlServer(Configuration.ConnectionString),
                    ServiceLifetime.Singleton
                );

            #region repositories

            services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
            services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
            services.AddSingleton<IOrderReadRepository, OrderReadRepository>();

            services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
            services.AddSingleton<IProductReadRepository, ProductReadRepository>();

            #endregion

            #region services
            #endregion
        }
    }
}