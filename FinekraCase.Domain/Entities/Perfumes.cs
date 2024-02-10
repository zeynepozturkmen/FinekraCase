namespace FinekraCase.Domain.Entities
{
    public class Perfumes : AuditEntity
    {
        public string PerfumeName { get; set; }
        public decimal Price { get; set; }
        public string? PhotoPath { get; set; }
        public Guid BrandId { get; set; }
        public Brands Brand { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public List<Baskets> Baskets { get; set; }
    }
}
