using System;

namespace Shop.Domain.Entities.INFPort
{
    public class GrowthContract
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public DateTime? Date { get; set; }
        public int? Capacity { get; set; }
        public int? ADSL { get; set; }
        public int? VDSL { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
    }
}
