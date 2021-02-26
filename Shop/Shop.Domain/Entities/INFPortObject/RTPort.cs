using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class RTPort
    {
        public long ID { get; set; }
        public int? Port { get; set; }
        public long? DeviceID { get; set; }
        public int? Type { get; set; }
        public int? Status { get; set; }
        public int? StatusColor { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string Description { get; set; }
    }
}
