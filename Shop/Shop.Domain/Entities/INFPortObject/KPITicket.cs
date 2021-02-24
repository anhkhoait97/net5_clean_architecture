using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class KPITicket
    {
        public long ID { get; set; }
        public long? BranchID { get; set; }
        public string NameBranch { get; set; }
        public int? Capacity { get; set; }
        public int? Baddie { get; set; }
        public string KPI_Bad { get; set; }
        public int? ADSLPortUse { get; set; }
        public int? ADSLNotOk { get; set; }
        public string KPI_DSP { get; set; }
        public int? PONPortUse { get; set; }
        public string PONNotOk { get; set; }
        public string KPI_OSP { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}

