using System;

namespace Shop.Domain.Entities.INFPort
{
    public class CorePairID
    {
        public long ID { get; set; }
        public long? CoreID { get; set; }
        public int? Type { get; set; }
        public long? DeviceID { get; set; }
        public int? Status { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Description { get; set; }
        public int? TypePort { get; set; }
        public DateTime? BookDate { get; set; }
        public string AccountImport { get; set; }
        public string Port { get; set; }
    }
}
