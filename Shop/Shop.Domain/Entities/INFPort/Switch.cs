using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Switch
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long? PopID { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Capacity { get; set; }
        public string Type { get; set; }
        public int? Status { get; set; }
        public string Ring { get; set; }
        public int? Ringnumber { get; set; }
        public string IP { get; set; }
        public string SNMP { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public long? RingID { get; set; }
        public string Address { get; set; }
        public int? TypeRing { get; set; }
        public string FirmWare { get; set; }
        public long? GeneralID { get; set; }
        public int? Flag { get; set; }
    }
}
