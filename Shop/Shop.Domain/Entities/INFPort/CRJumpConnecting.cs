using System;
namespace Shop.Domain.Entities.INFPort
{
    public class CRJumpConnecting
    {
        public long ID { get; set; }
        public long? PortIn { get; set; }
        public long PortOut { get; set; }
    }
}
