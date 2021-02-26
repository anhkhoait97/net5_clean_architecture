namespace Shop.Domain.Entities.INFPortObject
{
    public class OSPContractList
    {
        public long ID { get; set; }
        public string Contract { get; set; }
        public int? SlotID { get; set; }
        public int? PortID { get; set; }
        public int? Status { get; set; }
        public string Description { get; set; }
        public int? LocationID { get; set; }
        public string OLT { get; set; }
    }
}
