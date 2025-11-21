using static CommercialChain.Data.Enums4DaSoul;

namespace CommercialChain.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ProductType ProductType { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Code { get; set; } = string.Empty;
    }
}
