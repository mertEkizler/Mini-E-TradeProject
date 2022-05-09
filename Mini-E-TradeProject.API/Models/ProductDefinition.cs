namespace Mini_E_TradeProject.API.Models
{
    public class ProductDefinition : BaseDefinition
    {
        public string Name { get; set; }

        public int Stock { get; set; }

        public float Price { get; set; }
    }
}