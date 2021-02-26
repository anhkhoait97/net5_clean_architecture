using System;

namespace Shop.Domain.Entities.INFPort
{
    public class History_PortADSL
    {
        public long ID { get; set; }
        public long? PortID { get; set; }
        public string Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string Description { get; set; }
        public string IP { get; set; }
        public int? LocationID { get; set; }
        public string Description1 { get; set; }
    }
}
