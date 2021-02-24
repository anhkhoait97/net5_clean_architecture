using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TRouteCableDetail
    {
        public long ID { get; set; }
        public string CableName { get; set; }
        public string TubeName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? PiFullFlag { get; set; }
        public string Length { get; set; }
        public int? RowNumber { get; set; }
        public long? CableID { get; set; }
        public long? ContractID { get; set; }
    }
}

