using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class Module
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string ModuleType { get; set; }
        public string ClassType { get; set; }
        public short? ChildClassSupport { get; set; }
        public short? PortMatrix { get; set; }
        public string PortFormat { get; set; }
        public int? Parameter { get; set; }
        public string PortStep { get; set; }
        public string Description { get; set; }
        public long? VendorListID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
