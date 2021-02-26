using System;
namespace Shop.Domain.Entities.INFPort
{
    public class ListDevice
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Extensions { get; set; }
        public int? Capacity { get; set; }
        public string Production { get; set; }
        public string Description { get; set; }
        public int? Type { get; set; }
        public int? ValueInside { get; set; }
        public string SNMP_FTN { get; set; }
        public string SNMP_FTM { get; set; }
        public string SNMP_FTS { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? DeviceLine { get; set; }
        public int? Model { get; set; }
    }
}
