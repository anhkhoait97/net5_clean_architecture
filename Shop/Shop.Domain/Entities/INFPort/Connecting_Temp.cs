using System;

namespace Shop.Domain.Entities.INFPort
{
    public class Connecting_Temp
    {
        public long ID { get; set; }
        public long PortIn { get; set; }
        public long PortOut { get; set; }
        public long? ContractID { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public long? LocationID { get; set; }
        public string Cause { get; set; }
        public int? TypeCause { get; set; }
        public int? TypePort { get; set; }
        public int? Type { get; set; }
        public string ReturnCause { get; set; }
        public int? CardNumber { get; set; }
    }
}
