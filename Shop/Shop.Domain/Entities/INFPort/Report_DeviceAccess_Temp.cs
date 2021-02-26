using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Report_DeviceAccess_Temp
    {
        public long ID { get; set; }
        public string STT { get; set; }
        public string IP { get; set; }
        public string DeviceConfig { get; set; }
        public string DeviceUpdate { get; set; }
        public string Slot { get; set; }
        public string DeviceConfirm { get; set; }
        public string FirmwareConfig { get; set; }
        public string FirmwareUpdate { get; set; }
        public string FirmwareConfirm { get; set; }
        public string Comment { get; set; }
    }
}
