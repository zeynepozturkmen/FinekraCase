namespace FinekraCase.Domain.Entities
{
    public class BaseEntity : IEntity<Guid>
    {
        public Guid Id { get; set; } = SequentialGuid.NewSequentialGuid();
    }
}
