using System;

namespace Shop.Domain.Entities.INFPort
{
    public class TRouteTube
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? LocationID { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string Plans { get; set; }
        public long? ConstructionID { get; set; }
        public string ConstructionName { get; set; }
    }
}
