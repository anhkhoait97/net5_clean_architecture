using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class General
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public long? HostDevice { get; set; }
        public string SystemName { get; set; }
        public long? DeviceTypeID { get; set; }
        public string SystemDescription { get; set; }
        public string Asset { get; set; }
        public string CustomSN { get; set; }
        public string Inventory { get; set; }
        public string OS { get; set; }
        public string Extension { get; set; }
        public int? DepartmentID { get; set; }
        public string Version { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? FromAPI { get; set; }
        public int? ObjectType { get; set; }
        public long? ObjectID { get; set; }
        public int? Status { get; set; }
    }
}

