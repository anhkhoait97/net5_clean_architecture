using System;
namespace Shop.Domain.Entities.INFPort
{
    public class ReportContract_Evict
    {
        public int ID { get; set; }
        public string ContractName { get; set; }
        public string OldODCCable { get; set; }
        public string NewODCCable { get; set; }
        public int Type { get; set; }
        public int? Status { get; set; }
        public long? LocationID { get; set; }
        public long? BranchID { get; set; }
        public long? PopID { get; set; }
        public long? WardID { get; set; }
        public string DistrictID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
