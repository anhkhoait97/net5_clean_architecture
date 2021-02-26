using Shop.Domain.Common;
using System;

namespace Shop.Domain.Entities.INFPort
{
    public class PON_Device : BaseEntity
    {
        public string Name { get; set; }
        public int? Type { get; set; }
        public string TypeDevice { get; set; }
        public int? IsDevice { get; set; }
        public int? TypeBuilding { get; set; }
        public int? BuildingID { get; set; }
        public string BuildingName { get; set; }
        public string Address { get; set; }
        public long? Ward { get; set; }
        public long? District { get; set; }
        public long? LocationID { get; set; }
        public string Functions { get; set; }
        public string Connect { get; set; }
        public int? Capacity1 { get; set; }
        public int? Capacity2 { get; set; }
        public int? Capacity3 { get; set; }
        public string UpLinkODCCableType { get; set; }
        public int? Level { get; set; }
        public int? ManufactureID { get; set; }
        public string ProductName { get; set; }
        public string ParentName { get; set; }
        public long? ParentID { get; set; }
        public string Method { get; set; }
        public string Plans { get; set; }
        public string Equipment { get; set; }
        public int? Status { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateUse { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string Technology { get; set; }
        public int? Deploy { get; set; }
        public string Pop_Device { get; set; }
        public int? Length { get; set; }
        public int? Flag { get; set; }
        public string Infrastructure { get; set; }
        public int? InvestCapacity { get; set; }
        public string StatusDescription { get; set; }
        public int? IsObject { get; set; }
        public string NameInfor { get; set; }
        public string TCName { get; set; }
        public int? Signal { get; set; }
        public int? MATERIALID { get; set; }
        public int? ElectListID { get; set; }
        public DateTime? StatusDate { get; set; }
        public string PointEnd { get; set; }
    }
}
