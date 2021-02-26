namespace Shop.Domain.Entities.INFPort
{
    public class ContractOSP_List
    {
        public long ID { get; set; }
        public string Contract { get; set; }
        public string POLT { get; set; }
        public string PSlot { get; set; }
        public string PPort { get; set; }
        public string PointSet { get; set; }
        public string IOLT { get; set; }
        public string ISlot { get; set; }
        public string IPort { get; set; }
        public string Description { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
    }
}
