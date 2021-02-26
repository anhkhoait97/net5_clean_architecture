namespace Shop.Domain.Common
{
    // This can be modified to BaseEntity<TId> to support multiple key types (e.g. Guid)
    public abstract class BaseEntity
    {
        public long ID { get; set; }
    }
}
