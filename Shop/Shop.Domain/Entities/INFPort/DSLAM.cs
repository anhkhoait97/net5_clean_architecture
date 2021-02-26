using System;
namespace Shop.Domain.Entities.INFPort
{
    public class DSLAM
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int SLot { get; set; }
        public long? PopID { get; set; }
        public string Description { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? isEnable { get; set; }
        public string IP { get; set; }
        public string SNMP { get; set; }
        public int? DeviceType { get; set; }
        public int? Type { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? TypeDevice { get; set; }
        public string Address { get; set; }
        public int? TypeRing { get; set; }
        public string Ring { get; set; }
        public int? RingNumber { get; set; }
        public long? RingID { get; set; }
        public long? GeneralID { get; set; }
    }
}
