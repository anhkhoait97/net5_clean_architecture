using System;
namespace Shop.Domain.Entities.INFPort
{
    public class CRPort
    {
        public long ID { get; set; }
        public int? Port { get; set; }
        public int? Type { get; set; }
        public int? Status { get; set; }
        public long? DeviceID { get; set; }
    }
}
