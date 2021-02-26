using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TContractExtension
    {
        public long ID { get; set; }
        public long? TContractID { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Extension { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
