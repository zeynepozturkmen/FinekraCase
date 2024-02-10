namespace FinekraCase.Domain.Entities
{
    public class OrderDetails : AuditEntity
    {
        public Guid OrderId { get; set; }
        public Orders Order { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set;}
        public Guid PerfumeId { get; set; }
        public Perfumes Perfume { get; set; }
    }
}
