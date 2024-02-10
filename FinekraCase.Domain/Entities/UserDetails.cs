namespace FinekraCase.Domain.Entities
{
    public class UserDetails : AuditEntity
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string? Address { get; set; }
        public List<Orders> Orders { get; set; }
        public List<Baskets> Baskets { get; set; }
    }
}
