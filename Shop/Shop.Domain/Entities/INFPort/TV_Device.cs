using System;
namespace Shop.Domain.Entities.INFPort
{
    public class TV_Device
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public int? TypeListID { get; set; }
        public string Address { get; set; }
        public int? DistrictID { get; set; }
        public int? WardID { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? LocationID { get; set; }
        public int? Capacity { get; set; }
        public long? NodeID { get; set; }
        public long? Headend { get; set; }
        public string ODCCableType { get; set; }
        public DateTime? DateUse { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
