using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TRuleUserContract
    {
        public long ID { get; set; }
        public string UserID { get; set; }
        public long? TContractID { get; set; }
        public string ContractName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}

