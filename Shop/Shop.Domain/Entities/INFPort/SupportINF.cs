using System;
namespace Shop.Domain.Entities.INFPort
{
    public class SupportINF
    {
        public long ID { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public long? PopID { get; set; }
        public string INFMaintain { get; set; }
        public string Address { get; set; }
        public int? Ward { get; set; }
        public int? District { get; set; }
        public int? Type { get; set; }
        public string Description { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
