using System;

namespace Shop.Domain.Entities.INFPort
{
    public class CRRouteCable
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Layer { get; set; }
        public string Description { get; set; }
        public string Building { get; set; }
        public double? Investment { get; set; }
        public string Content { get; set; }
        public string Formality { get; set; }
        public string OrderCable { get; set; }
        public int? LocationID { get; set; }
        public int? Priority { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string Code { get; set; }
        public int? GroupID { get; set; }
    }
}
