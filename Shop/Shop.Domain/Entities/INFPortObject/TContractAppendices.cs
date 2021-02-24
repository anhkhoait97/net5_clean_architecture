using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TContractAppendices
    {
        public long ID { get; set; }
        public long? TContractID { get; set; }
        public string Name { get; set; }
        public long? PartnerID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int StatusPay { get; set; }
        public int? StatusContract { get; set; }
        public int? Cycle_Pay { get; set; }
        public int? Number_Pay { get; set; }
        public string TotalReal { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }

}
