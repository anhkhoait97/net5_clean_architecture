using System;
namespace Shop.Domain.Entities.INFPort
{
    public class PON_Port
    {
        public long ID { get; set; }
        public int? Port { get; set; }
        public long DeviceID { get; set; }
        public int Type { get; set; }
        public int TypeDevice { get; set; }
        public int? Status { get; set; }
        public int? Flag { get; set; }
        public int Active { get; set; }
        public string StartODCCableType { get; set; }
        public string EndODCCableType { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string Description { get; set; }
        public string OLT { get; set; }
        public int? SlotOLT { get; set; }
        public long? PortCard { get; set; }
        public int? TypePort { get; set; }
        public DateTime? BookDate { get; set; }
        public string AccountImport { get; set; }
        public double? Power { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
