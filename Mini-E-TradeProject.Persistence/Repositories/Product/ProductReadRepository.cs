using Mini_E_TradeProject.Application.Repositories;
using Mini_E_TradeProject.Domain.Entities.Concrete;
using Mini_E_TradeProject.Persistence.Contexts;

namespace Mini_E_TradeProject.Persistence.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ETradeDBContext context) : base(context)
        {
        }
    }
}