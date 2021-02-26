using System;
namespace Shop.Domain.Entities.INFPort
{
    public class PillarCrossStreet
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long? PillarID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
