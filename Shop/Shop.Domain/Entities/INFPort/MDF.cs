using System;
namespace Shop.Domain.Entities.INFPort
{
    public class MDF
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long? PopID { get; set; }
        public string Description { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? Capacity { get; set; }
        public int? Status { get; set; }
        public byte? Confrm { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? TypeDevice { get; set; }
    }
}
