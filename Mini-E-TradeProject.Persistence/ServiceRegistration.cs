using Microsoft.Extensions.DependencyInjection;
using Mini_E_TradeProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Mini_E_TradeProject.Application.Repositories;
using Mini_E_TradeProject.Persistence.Repositories;
using Mini_E_TradeProject.Infrastructure.Services.Abstract;
using Mini_E_TradeProject.Infrastructure.Services.Concrete;

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

            #region repositories

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();

            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();

            #endregion

            #region services

            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IOrderService, OrderManager>();

            #endregion
        }
    }
}