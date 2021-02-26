using System;
namespace Shop.Domain.Entities.INFPort
{
    public class SupportINFDetail
    {
        public long ID { get; set; }
        public int? Type { get; set; }
        public int? Brand { get; set; }
        public string Model { get; set; }
        public int? Power { get; set; }
        public string Capacity { get; set; }
        public long? SupportINFID { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
