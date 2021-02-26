using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class DeviceHistory
    {
        public long ID { get; set; }
        public string Action { get; set; }
        public long? GenralD { get; set; }
        public string Name { get; set; }
        public long? HostDevice { get; set; }
        public long? DeviceTypeID { get; set; }
        public long? SiteID { get; set; }
        public long? RoomID { get; set; }
        public long? RackID { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? DepartmentID { get; set; }
    }
}
