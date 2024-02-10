namespace FinekraCase.Domain.Entities
{
    public class Baskets : AuditEntity
    {
        public Guid UserDetailId { get; set; }
        public UserDetails UserDetail { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public Guid PerfumeId { get; set; }
        public Perfumes Perfume { get; set; }
    }
}
