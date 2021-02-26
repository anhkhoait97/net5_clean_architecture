namespace Shop.Domain.Entities.INFPort
{
    public class PORT
    {
        public long ID { get; set; }
        public int? PortID { get; set; }
        public int? TypeID { get; set; }
        public long? Code { get; set; }
        public short? Status { get; set; }
        public int? PortMDF { get; set; }
        public string Description { get; set; }
        public string Description1 { get; set; }
    }
}
