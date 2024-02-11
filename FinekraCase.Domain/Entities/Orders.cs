namespace FinekraCase.Domain.Entities
{
    public class Orders : AuditEntity
    {
        public Guid UserDetailId { get; set; }
        public UserDetails UserDetail { get; set; }
        public string ShipAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }=new List<OrderDetails>();
    }
}
