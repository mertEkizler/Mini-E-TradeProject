using Mini_E_TradeProject.Domain.Entities.Common;

namespace Mini_E_TradeProject.Domain.Entities.Concrete
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}