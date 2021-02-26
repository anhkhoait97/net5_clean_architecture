using System;
namespace Shop.Domain.Entities.INFPort
{
    public class ContractDSP
    {
        public int? ID { get; set; }
        public string DSLAMName { get; set; }
        public string Name { get; set; }
        public string IP { get; set; }
        public string SNMP { get; set; }
        public int? SlotID { get; set; }
        public int? PortID { get; set; }
        public int? Type { get; set; }
        public string TypeCard { get; set; }
        public int? Capacity { get; set; }
        public string Contract { get; set; }
    }
}
