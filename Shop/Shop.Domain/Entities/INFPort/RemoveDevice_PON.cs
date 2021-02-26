using System;
namespace Shop.Domain.Entities.INFPort
{
    public class RemoveDevice_PON
    {
        public long ID { get; set; }
        public string DeviceID { get; set; }
        public string Type { get; set; }
        public string DeviceName { get; set; }
    }
}
