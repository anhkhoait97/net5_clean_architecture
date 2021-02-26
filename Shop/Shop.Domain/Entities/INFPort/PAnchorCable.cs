using System;

namespace Shop.Domain.Entities.INFPort
{
    public class PAnchorCable
    {
        public long ID { get; set; }
        public int? Type { get; set; }
        public long? PillarID { get; set; }
        public string PillarName { get; set; }
        public long? ObjectID { get; set; }
        public string ObjectName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
