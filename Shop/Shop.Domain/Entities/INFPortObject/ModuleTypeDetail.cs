using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class ModuleTypeDetail
    {
        public long ID { get; set; }
        public long? DeviceTypeID { get; set; }
        public long? ModuleID { get; set; }
        public short? Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
