namespace Shop.Domain.Entities.INFPort
{
    public class Street
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long? District { get; set; }
        public long? LocationId { get; set; }
    }
}
