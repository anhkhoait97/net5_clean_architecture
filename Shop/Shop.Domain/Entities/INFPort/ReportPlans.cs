using System;

namespace Shop.Domain.Entities.INFPort
{
    public class ReportPlans
    {
        public long ID { get; set; }
        public string Pop { get; set; }
        public string Plans { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Name { get; set; }
        public long? ContractID { get; set; }
        public int? Capacity { get; set; }
        public int? Type { get; set; }
        public DateTime? Date { get; set; }
    }
}
