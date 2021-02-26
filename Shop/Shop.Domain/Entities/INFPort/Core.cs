using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Core
    {
        public long ID { get; set; }
        public string FromDevice { get; set; }
        public string ToDevice { get; set; }
        public decimal? Status { get; set; }
        public int? Duct { get; set; }
        public int? Type { get; set; }
        public long? DeviceID { get; set; }
    }
}
