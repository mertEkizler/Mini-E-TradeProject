namespace Mini_E_TradeProject.Infrastructure.Models
{
    public class ProductModel : BaseModel
    {
        public string Name { get; set; }

        public int Stock { get; set; }

        public float Price { get; set; }
    }
}