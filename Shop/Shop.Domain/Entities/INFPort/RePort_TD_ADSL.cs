using System;
namespace Shop.Domain.Entities.INFPort
{
    public class RePort_TD_ADSL
    {
        public long ID { get; set; }
        public string Location { get; set; }
        public string BranchID { get; set; }
        public string BranchName { get; set; }
        public string PopName { get; set; }
        public string TC { get; set; }
        public string TD { get; set; }
        public string Sumport { get; set; }
        public string PortUser { get; set; }
        public string PortDie { get; set; }
        public string PortFree { get; set; }
        public string PortMaintan { get; set; }
        public string PercenPortDie { get; set; }
        public string PerformanceUser { get; set; }
        public string Broken { get; set; }
        public string Building { get; set; }
        public string Plans { get; set; }
        public string Address { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string DateUser { get; set; }
        public string DateRun { get; set; }
        public string CreateDate { get; set; }
        public int? Region { get; set; }
    }
}
