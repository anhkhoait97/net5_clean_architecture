using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class ListBuilding
    {
        public long ID { get; set; }
        public long? BuildingID { get; set; }
        public string Code { get; set; }
        public string BuildingName { get; set; }
        public string Name { get; set; }
        public int? LocationID { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Address { get; set; }
        public string Scale { get; set; }
        public string DT { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ADSLPort { get; set; }
        public int? FTTHPort { get; set; }
        public int? PONPort { get; set; }
        public int? KTXPort { get; set; }
        public int? EoCPort { get; set; }
        public string InvestName { get; set; }
        public int? InvestValues { get; set; }
        public string PartnerName { get; set; }
    }
}
