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
                    options => options.UseSqlServer(Configuration.ConnectionString)
                );

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();

            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
        }
    }
}