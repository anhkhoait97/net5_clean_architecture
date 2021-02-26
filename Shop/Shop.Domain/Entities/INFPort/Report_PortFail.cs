using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Report_PortFail
    {
        public long ID { get; set; }
        public string No { get; set; }
        public string PopName { get; set; }
        public string Name { get; set; }
        public string Port { get; set; }
        public string PortBad { get; set; }
        public string PortDied { get; set; }
        public string Street { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public long? BranchID { get; set; }
        public string TypeDevice { get; set; }
        public int? Type { get; set; }
    }
}
