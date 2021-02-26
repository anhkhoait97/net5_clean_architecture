using System;
namespace Shop.Domain.Entities.INFPort
{
    public class PON_PortDie
    {
        public long ID { get; set; }
        public string No { get; set; }
        public string Pop { get; set; }
        public string IsType { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Totalport { get; set; }
        public string PortDie1 { get; set; }
        public string PortDie2 { get; set; }
        public string Address { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public int? BranchID { get; set; }
        public int? LocationID { get; set; }
    }
}
