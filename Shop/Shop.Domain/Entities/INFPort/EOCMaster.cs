using System;

namespace Shop.Domain.Entities.INFPort
{
    public class EOCMaster
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? Capacity { get; set; }
        public int? Type { get; set; }
        public int? TypeDevice { get; set; }
        public string Address { get; set; }
        public int? DistrictID { get; set; }
        public int? WardID { get; set; }
        public long? DeviceID { get; set; }
        public long? CoreID { get; set; }
        public int? Status { get; set; }
        public string Description { get; set; }
        public int? Length { get; set; }
        public string IP { get; set; }
        public string SNMP { get; set; }
        public int? PartnerID { get; set; }
        public string PartnerName { get; set; }
        public string ODCCableType { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public DateTime? DateUse { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? TypeBuilding { get; set; }
        public int? BuildingID { get; set; }
        public string BuildingName { get; set; }
        public int? Investment { get; set; }
        public string Lot { get; set; }
        public int? Floor { get; set; }
    }
}
