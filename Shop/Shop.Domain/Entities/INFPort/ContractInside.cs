using System;
namespace Shop.Domain.Entities.INFPort
{
    public class ContractInside
    {
        public string Contract { get; set; }
        public string DSLAM { get; set; }
        public int? SlotID { get; set; }
        public int? PortID { get; set; }
        public int ID { get; set; }
    }
}
