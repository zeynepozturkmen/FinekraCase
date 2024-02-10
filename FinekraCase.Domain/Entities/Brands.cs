namespace FinekraCase.Domain.Entities
{
    public class Brands : AuditEntity
    {
        public string BrandName { get; set; }
        public string? Description { get; set; }
        public List<Perfumes> Perfumes { get; set; }
    }
}
