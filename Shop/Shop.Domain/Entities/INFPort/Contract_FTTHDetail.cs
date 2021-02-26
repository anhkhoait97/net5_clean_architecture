using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Contract_FTTHDetail
    {
        public long ID { get; set; }
        public long? ContractID { get; set; }
        public string ODCCable { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public int? Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public long? CorePairID { get; set; }
    }
}
