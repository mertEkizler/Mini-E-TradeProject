using Mini_E_TradeProject.Application.Repositories;
using Mini_E_TradeProject.Domain.Entities.Concrete;
using Mini_E_TradeProject.Persistence.Contexts;

namespace Mini_E_TradeProject.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ETradeDBContext context) : base(context)
        {
        }
    }
}