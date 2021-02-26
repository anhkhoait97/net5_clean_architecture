using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TNumberPayHistory
    {
        public long ID { get; set; }
        public long? TContractID { get; set; }
        public long? NumberPayID { get; set; }
        public string ContractName { get; set; }
        public DateTime? PayDate { get; set; }
        public string StatusString { get; set; }
        public int? NumberType { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
