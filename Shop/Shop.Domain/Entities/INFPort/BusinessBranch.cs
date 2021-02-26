using System;

namespace Shop.Domain.Entities.INFPort
{
    public class BusinessBranch
    {
        public long ID { get; set; }
        public int? BranchID { get; set; }
        public string DistrictID { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
