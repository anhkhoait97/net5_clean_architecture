using System;

namespace Shop.Domain.Entities.INFPort
{
    public class DeviceRecovery
    {
        public long ID { get; set; }
        public int LocationID { get; set; }
        public int BranchID { get; set; }
        public string PopName { get; set; }
        public string TCName { get; set; }
        public string TDName { get; set; }
        public int? Capacity { get; set; }
        public int? PortUser { get; set; }
        public int? PortFree { get; set; }
        public int? PortDie { get; set; }
        public int? Maintain { get; set; }
        public string Adress { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? TypeDevice { get; set; }
        public int Type { get; set; }
    }
}
