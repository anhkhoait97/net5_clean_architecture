using System;
namespace Shop.Domain.Entities.INFPort
{
    public class PON_LoggingPort
    {
        public long ID { get; set; }
        public long? PortID { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string IP { get; set; }
        public long? LocationID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
