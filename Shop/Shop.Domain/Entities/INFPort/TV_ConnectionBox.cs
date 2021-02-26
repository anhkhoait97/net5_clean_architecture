using System;
namespace Shop.Domain.Entities.INFPort
{
    public class TV_ConnectionBox
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string TypeDevice { get; set; }
        public int? TypeBuilding { get; set; }
        public int? BuildingID { get; set; }
        public string BuildingName { get; set; }
        public string Address { get; set; }
        public long? Ward { get; set; }
        public long? District { get; set; }
        public long? LocationID { get; set; }
        public string Connect { get; set; }
        public int? Capacity { get; set; }
        public int? ManufactureID { get; set; }
        public string ProductName { get; set; }
        public int? TypeParent { get; set; }
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
        public int? Deploy { get; set; }
        public long? OldID { get; set; }
    }
}
