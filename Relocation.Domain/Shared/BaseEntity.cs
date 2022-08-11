namespace Relocation.Domain.Shared
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}