using Mini_E_TradeProject.Application.Abstraction;
using Mini_E_TradeProject.Domain.Entities.Concrete;

namespace Mini_E_TradeProject.Persistence.Concrete
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Lenovo PC",
                    Price = 14550,
                    Stock = 12
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Asus PC",
                    Price = 13000,
                    Stock = 23
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "HP PC",
                    Price = 12440,
                    Stock = 15
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Casper PC",
                    Price = 10000,
                    Stock = 28
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Monster PC",
                    Price = 20000,
                    Stock = 15
                }
            };
    }
}