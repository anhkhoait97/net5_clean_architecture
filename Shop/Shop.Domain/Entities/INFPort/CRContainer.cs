using System;
namespace Shop.Domain.Entities.INFPort
{
    public class CRContainer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public int? Status { get; set; }
        public string Description { get; set; }
        public int? RouteCableID { get; set; }
        public int? LocationID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? TypeDevice { get; set; }
    }
}
