using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Report_DeviceAccess
    {
        public long ID { get; set; }
        public string IP { get; set; }
        public string TypeDevice { get; set; }
        public string Device_Config { get; set; }
        public string Device_Update { get; set; }
        public string Device_Confirm { get; set; }
        public int? Slot { get; set; }
        public string Firmware_Config { get; set; }
        public string Firmware_Update { get; set; }
        public string Firmware_Confirm { get; set; }
        public string Description { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
