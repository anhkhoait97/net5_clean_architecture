using System;

namespace Shop.Domain.Entities.INFPort
{
    public class Contract_Temp
    {
        public long ID { get; set; }
        public long? ContractID { get; set; }
        public int? Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public int? Status { get; set; }
        public string ODCCableType { get; set; }
    }
}
