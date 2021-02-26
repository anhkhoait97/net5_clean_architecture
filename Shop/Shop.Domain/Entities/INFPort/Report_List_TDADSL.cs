using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Report_List_TDADSL
    {
        public long ID { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public string NameBranch { get; set; }
        public string Pop { get; set; }
        public string TC { get; set; }
        public string TD { get; set; }
        public int? Port { get; set; }
        public int? PortUse { get; set; }
        public int? PortFail { get; set; }
        public int? PortMaintain { get; set; }
        public int? PortFree { get; set; }
        public string PercenFail { get; set; }
        public string PerformaceUsed { get; set; }
        public string Broken { get; set; }
        public int? PerformaceValue { get; set; }
        public int? FailValues { get; set; }
        public string PercenPort { get; set; }
        public int? TypeBuilding { get; set; }
        public string BuildingName { get; set; }
        public string Plans { get; set; }
        public string Address { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string DateUse { get; set; }
        public string TimeLine { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
