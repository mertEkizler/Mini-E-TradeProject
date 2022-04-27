using Mini_E_TradeProject.Domain.Entities.Common;

namespace Mini_E_TradeProject.Domain.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public int Stock { get; set; }

        public long Price { get; set; }
    }
}