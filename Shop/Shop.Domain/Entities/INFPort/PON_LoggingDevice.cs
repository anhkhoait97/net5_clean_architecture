using System;

namespace Shop.Domain.Entities.INFPort
{
    public class PON_LoggingDevice
    {
        public long ID { get; set; }
        public long? IDDevice { get; set; }
        public string NameDevice { get; set; }
        public string OldStatus { get; set; }
        public string NewStatus { get; set; }
        public string Description { get; set; }
        public string IP { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? LocationID { get; set; }
        public long? BranchID { get; set; }
    }
}
