using System;

namespace Shop.Domain.Entities.INFPort
{
    public class ContractOSP
    {
        public long ID { get; set; }
        public string Contract { get; set; }
        public string OLTName { get; set; }
        public int? SlotID { get; set; }
        public int? PortID { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? LocationID { get; set; }
        public DateTime? FirstAccess { get; set; }
        public DateTime? Start_Date { get; set; }
        public int? Status { get; set; }
        public int? Type { get; set; }
        public string Description { get; set; }
    }
}
