using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class ModulesManagerment
    {
        public long ID { get; set; }
        public long? GeneralID { get; set; }
        public long? DepartmentID { get; set; }
        public string SlotFormat { get; set; }
        public int? SlotUsed { get; set; }
        public string IndexNumber { get; set; }
        public string ParentIndex { get; set; }
        public string Class { get; set; }
        public long? ModuleTemplateID { get; set; }
        public string ModuleType { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string HardwareRevision { get; set; }
        public string FirmwareRevision { get; set; }
        public string SoftwareRevision { get; set; }
        public short? FRU { get; set; }
        public DateTime? FirstDiscovered { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string Version { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? FromAPI { get; set; }
    }
}
