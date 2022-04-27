using Microsoft.Extensions.DependencyInjection;
using Mini_E_TradeProject.Application.Abstraction;
using Mini_E_TradeProject.Persistence.Concrete;

namespace Mini_E_TradeProject.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}