using System;
namespace Shop.Domain.Entities.INFPort
{
    public class PON_OLT
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long PopID { get; set; }
        public int? Capacity { get; set; }
        public int? Type { get; set; }
        public int? Status { get; set; }
        public int? TypeRing { get; set; }
        public int? RingNumber { get; set; }
        public long? RingID { get; set; }
        public string Ring { get; set; }
        public string IP { get; set; }
        public string SNMP { get; set; }
        public int? OutputPower { get; set; }
        public string Equipment { get; set; }
        public string Plans { get; set; }
        public string Description { get; set; }
        public long? ManagementID { get; set; }
        public long? ManufactureID { get; set; }
        public string ProductName { get; set; }
        public DateTime? ActiveDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string Technology { get; set; }
        public string FirmWare { get; set; }
    }
}
