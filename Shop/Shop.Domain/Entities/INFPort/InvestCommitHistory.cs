using System;

namespace Shop.Domain.Entities.INFPort
{
    public class InvestCommitHistory
    {
        public long ID { get; set; }
        public string PopName { get; set; }
        public string Name { get; set; }
        public int? InvestCapacity { get; set; }
        public int? ThreeMonths { get; set; }
        public int? SixMonths { get; set; }
        public int? SepMonths { get; set; }
        public int? DecMonths { get; set; }
        public string Description { get; set; }
        public int? Type { get; set; }
        public long? TD_ID { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? IC_ID { get; set; }
    }
}
