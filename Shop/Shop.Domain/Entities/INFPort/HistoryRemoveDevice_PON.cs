using System;

namespace Shop.Domain.Entities.INFPort
{
    public class HistoryRemoveDevice_PON
    {
        public long ID { get; set; }
        public string POPName { get; set; }
        public string Name { get; set; }
        public int? Capacity { get; set; }
        public int? PortUser { get; set; }
        public int? PortFree { get; set; }
        public int? PortDie { get; set; }
        public int? PortMainten { get; set; }
        public string Adress { get; set; }
        public DateTime? CreateDate { get; set; }
        public int Type { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public int? TypeDevice { get; set; }
        public string NameDevice { get; set; }
        public int? TypeObj { get; set; }
        public string NameObj { get; set; }
        public int? Flag { get; set; }
        public string CreateBy { get; set; }
        public string IP { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
