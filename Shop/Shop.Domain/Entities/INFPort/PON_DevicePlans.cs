using System;

namespace Shop.Domain.Entities.INFPort
{
    public class PON_DevicePlans
    {
        public long ID { get; set; }
        public long? DeviceID { get; set; }
        public string Name { get; set; }
        public string Plans { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
