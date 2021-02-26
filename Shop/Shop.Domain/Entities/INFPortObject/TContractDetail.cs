using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TContractDetail
    {
        public long ID { get; set; }
        public long? TContractID { get; set; }
        public long? TacitID { get; set; }
        public string CodeTacit { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
