using System;

namespace Shop.Domain.Entities.INFPort
{
    public class TV_Connecting
    {
        public long ID { get; set; }
        public long? PortIn { get; set; }
        public long? PortOut { get; set; }
        public string TypeConnect { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
