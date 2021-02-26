using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class BlackInventoryList
    {
        public long ID { get; set; }
        public string DeviceName { get; set; }
        public long? DeviceID { get; set; }
        public string OldIP { get; set; }
        public string NewIP { get; set; }
        public string OldStatus { get; set; }
        public string NewStatus { get; set; }
        public int? Type { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
