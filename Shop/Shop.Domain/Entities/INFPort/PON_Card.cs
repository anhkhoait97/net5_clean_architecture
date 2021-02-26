using System;
namespace Shop.Domain.Entities.INFPort
{
    public class PON_Card
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long OLTID { get; set; }
        public int? Capacity { get; set; }
        public int? Slot { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public string CardName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? ONU { get; set; }
    }
}
