using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class CMDevice
    {
        public long ID { get; set; }
        public long? DeviceID { get; set; }
        public long? ObjectID { get; set; }
        public int Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Flag { get; set; }
    }
}

