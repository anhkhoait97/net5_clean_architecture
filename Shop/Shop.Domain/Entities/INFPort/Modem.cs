using System;

namespace Shop.Domain.Entities.INFPort
{
    public class Modem
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public int? Capacity { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string ODCCableType { get; set; }
        public int? Status { get; set; }
        public string IP { get; set; }
        public string SNMP { get; set; }
        public int? LocationID { get; set; }
        public int? TypeCard { get; set; }
        public long? PortIn { get; set; }
        public long? PortOut { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
