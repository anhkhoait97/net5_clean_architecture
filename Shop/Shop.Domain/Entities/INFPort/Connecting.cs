namespace Shop.Domain.Entities.INFPort
{
    public class Connecting
    {
        public long ID { get; set; }
        public long? PortIN { get; set; }
        public long? PortOUT { get; set; }
        public bool? Status { get; set; }
        public long? ContractID { get; set; }
        public string CreateBy { get; set; }
        public int? Type { get; set; }
    }
}
