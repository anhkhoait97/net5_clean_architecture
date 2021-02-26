using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TacitLog
    {
        public long ID { get; set; }
        public long? TacitID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
