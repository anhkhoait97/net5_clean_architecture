using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class PortManagerment
    {
        public long ID { get; set; }
        public long? DeviceID { get; set; }
        public int? PortIndex { get; set; }
        public string Port { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? TypeListID { get; set; }
        public long? ModulesManagermentID { get; set; }
        public int? DepartmentID { get; set; }
        public long? SiteID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }

}

