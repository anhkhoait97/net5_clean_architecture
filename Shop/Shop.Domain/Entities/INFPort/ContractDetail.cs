using System;

namespace Shop.Domain.Entities.INFPort
{
    public class ContractDetail
    {
        public long ID { get; set; }
        public long? ContractID { get; set; }
        public string ODCCable { get; set; }
        public int? Status { get; set; }
        public long? LocationID { get; set; }
        public long? BranchID { get; set; }
        public int? Type { get; set; }
        public long? DeviceID { get; set; }
        public int? TypeDevice { get; set; }
        public long? PortID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
