using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TNumberPay
    {
        public long ID { get; set; }
        public long? TContractID { get; set; }
        public int? Number_Pay { get; set; }
        public DateTime? PayDate { get; set; }
        public int? StatusNumber { get; set; }
        public string StatusString { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string Appendices_Name { get; set; }
        public string UserConfim { get; set; }
        public DateTime? DateConfim { get; set; }
        public long? AppendicesID { get; set; }
    }

}
