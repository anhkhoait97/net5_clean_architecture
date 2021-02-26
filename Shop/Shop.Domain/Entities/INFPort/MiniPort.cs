using System;
namespace Shop.Domain.Entities.INFPort
{
    public class MiniPort
    {
        public long ID { get; set; }
        public int? Port { get; set; }
        public int? Type { get; set; }
        public long? DeviceID { get; set; }
        public int? Status { get; set; }
        public long? ContractID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string Description { get; set; }
    }
}
