using System;

namespace Shop.Domain.Entities.INFPort
{
    public class ReportModuleDevice
    {
        public long ID { get; set; }
        public long? POPID { get; set; }
        public int? Branch { get; set; }
        public int? Location { get; set; }
        public string DeviceType { get; set; }
        public string Model { get; set; }
        public string DeviceName { get; set; }
        public string IP { get; set; }
        public string SNMP { get; set; }
        public string CardName { get; set; }
        public string CardType { get; set; }
        public string UsePort { get; set; }
        public string ModuleType { get; set; }
        public string Capacity { get; set; }
        public string Status { get; set; }
        public string Core { get; set; }
        public string Distance { get; set; }
        public string ReceivedPower { get; set; }
        public string GivenPower { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Port { get; set; }
    }
}
