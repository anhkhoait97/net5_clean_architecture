using System;

namespace Shop.Domain.Entities.INFPort
{
    public class PON_RuleGroupStatusPort
    {
        public long ID { get; set; }
        public long? GroupID { get; set; }
        public int? OldStatus { get; set; }
        public int? NewStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
