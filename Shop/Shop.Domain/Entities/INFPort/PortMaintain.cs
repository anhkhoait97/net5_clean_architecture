using System;
namespace Shop.Domain.Entities.INFPort
{
    public class PortMaintain
    {
        public int ID { get; set; }
        public long? PortID { get; set; }
        public DateTime? BookDate { get; set; }
        public int? Flag { get; set; }
    }
}
