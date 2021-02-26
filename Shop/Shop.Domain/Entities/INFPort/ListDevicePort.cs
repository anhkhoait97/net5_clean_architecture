using System;

namespace Shop.Domain.Entities.INFPort
{
    public class ListDevicePort
    {
        public int ID { get; set; }
        public string Extensions { get; set; }
        public string Capacity { get; set; }
        public int? CapacityMapped { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Type { get; set; }
    }
}
