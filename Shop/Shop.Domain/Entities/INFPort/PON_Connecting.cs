using System;
namespace Shop.Domain.Entities.INFPort
{
    public class PON_Connecting
    {
        public long ID { get; set; }
        public long? PortIn { get; set; }
        public long? PortOut { get; set; }
        public long? ContractID { get; set; }
        public string Connect { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public int? Type { get; set; }
        public int? FlagODC { get; set; }
        public int? NumberBook { get; set; }
    }
}
