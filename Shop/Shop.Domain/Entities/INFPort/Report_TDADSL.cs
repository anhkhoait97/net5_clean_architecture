using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Report_TDADSL
    {
        public long ID { get; set; }
        public string PopName { get; set; }
        public int? Manager { get; set; }
        public string Name { get; set; }
        public int? City { get; set; }
        public string Address { get; set; }
        public string CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string Plans { get; set; }
        public string pWard { get; set; }
        public string pDistrict { get; set; }
        public string Parent { get; set; }
        public int? PortFail { get; set; }
        public int? PortFree { get; set; }
        public int? PortUse { get; set; }
        public int? PortDie { get; set; }
        public int? PortBaoTri { get; set; }
        public int? CapPhoi { get; set; }
        public int? TypeBuilding { get; set; }
        public DateTime? Date { get; set; }
    }
}
