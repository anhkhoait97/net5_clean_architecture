using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class RuleSwapPlan
    {
        public long ID { get; set; }
        public int? LocationID { get; set; }
        public string Plans { get; set; }
        public DateTime? BookDate { get; set; }
        public int? Type { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? Flag { get; set; }
    }
}
