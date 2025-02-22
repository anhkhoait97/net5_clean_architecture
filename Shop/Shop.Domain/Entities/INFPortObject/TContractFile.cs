using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TContractFile
    {
        public long ID { get; set; }
        public long? TContractID { get; set; }
        public string FileName { get; set; }
        public string LinkFile { get; set; }
        public int? Type { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
