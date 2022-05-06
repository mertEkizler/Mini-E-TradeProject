using Mini_E_TradeProject.Domain.Entities.Common;

namespace Mini_E_TradeProject.Domain.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }

        public string Address { get; set; }

        public ICollection<Product> Products { get; set; }

        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}