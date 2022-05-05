using Mini_E_TradeProject.Application.Repositories;
using Mini_E_TradeProject.Domain.Entities.Concrete;
using Mini_E_TradeProject.Persistence.Contexts;

namespace Mini_E_TradeProject.Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ETradeDBContext context) : base(context)
        {
        }
    }
}