using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class ModulesManagermentHistory
    {
        public long ID { get; set; }
        public string Action { get; set; }
        public long? ModuleManagermentID { get; set; }
        public long? General { get; set; }
        public int? Department { get; set; }
        public string SlotFormat { get; set; }
        public string IndexNumber { get; set; }
        public string ParentIndex { get; set; }
        public string Class { get; set; }
        public long? ModuleTemplateID { get; set; }
        public string ModuleName { get; set; }
        public string ModuleType { get; set; }
        public string Description { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
