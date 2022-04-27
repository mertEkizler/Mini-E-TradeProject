using Mini_E_TradeProject.Domain.Entities.Concrete;

namespace Mini_E_TradeProject.Application.Abstraction
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
