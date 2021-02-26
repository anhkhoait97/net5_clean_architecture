using System;
namespace Shop.Domain.Entities.INFPort
{
    public class TV_Port
    {
        public long ID { get; set; }
        public string Port { get; set; }
        public int? Type { get; set; }
        public int? TypePort { get; set; }
        public long? DeviceID { get; set; }
        public int? Status { get; set; }
        public int? Active { get; set; }
        public long? Parent { get; set; }
        public long? ContractID { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string Depreciation { get; set; }
        public string Unit { get; set; }
        public string StartODCCableType { get; set; }
        public string EndODCCableType { get; set; }
    }
}
