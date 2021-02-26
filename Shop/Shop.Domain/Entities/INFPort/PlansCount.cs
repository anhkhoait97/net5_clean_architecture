using System;

namespace Shop.Domain.Entities.INFPort
{
    public class PlansCount
    {
        public long ID { get; set; }
        public string Pop { get; set; }
        public string Plans { get; set; }
        public int? PortKB { get; set; }
        public int? TD { get; set; }
        public int? PortFree { get; set; }
        public int? PortUse { get; set; }
        public int? TDTH { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? Date { get; set; }
        public string Name { get; set; }
    }
}
