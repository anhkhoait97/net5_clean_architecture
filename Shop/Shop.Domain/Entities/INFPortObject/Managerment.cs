using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class Managerment
    {
        public long ID { get; set; }
        public DateTime? FirstDiscovered { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string OOB_HostName1 { get; set; }
        public string OOB_HostName2 { get; set; }
        public string OOB_Tel1 { get; set; }
        public string OOB_Tel2 { get; set; }
        public string Power1 { get; set; }
        public string Power2 { get; set; }
        public int? DepartmentID { get; set; }
        public long? GeneralID { get; set; }
        public short? Monitored { get; set; }
        public string MonitoringTemplate { get; set; }
        public int? PathCost { get; set; }
        public short? ManagedByCustomer { get; set; }
        public short? MonitorConfig { get; set; }
        public string ConfigGroup { get; set; }
        public long? FunctionCodeID { get; set; }
        public DateTime? DownFrom { get; set; }
        public DateTime? DownUntil { get; set; }
        public short? SNMP_Managed { get; set; }
        public short? AutoDNS { get; set; }
        public string Layers { get; set; }
        public string IPForward { get; set; }
        public int? SNMP_Version { get; set; }
        public short? SNMP_Bulk { get; set; }
        public short? AutoUpdate { get; set; }
        public int? AutoUpdateTime { get; set; }
        public short? SNMP_Polling { get; set; }
        public short? Collect_ARP { get; set; }
        public short? Collect_FWT { get; set; }
        public short? Collect_STPInfo { get; set; }
        public short? Collect_BGPInfo { get; set; }
        public short? Collect_OSPFInfo { get; set; }
        public short? Collect_ISISInfo { get; set; }
        public short? Collect_LLDPInfo { get; set; }
        public short? Collect_CDPInfo { get; set; }
        public short? Collect_HardWareInfo { get; set; }
        public short? Collect_VLANInfo { get; set; }
        public short? Collect_IPInfo { get; set; }
        public int? SNMPFailedAttempts { get; set; }
        public int? SNMP_Down { get; set; }
        public DateTime? Last_ARP { get; set; }
        public DateTime? Last_FWT { get; set; }
        public string SNMP_Community { get; set; }
        public short? IPV4_Only { get; set; }
        public string SNMP_Target_Address { get; set; }
        public string SNMP_Target_V6Address { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
