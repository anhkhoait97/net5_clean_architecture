using System;

namespace Shop.Domain.Entities.INFPort
{
    public class FirmWareDevice
    {
        public int ID { get; set; }
        public string Firmware { get; set; }
        public int? DeviceID { get; set; }
        public int? Slot { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
