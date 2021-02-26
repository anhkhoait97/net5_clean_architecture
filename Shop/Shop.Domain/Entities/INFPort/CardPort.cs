using System;
namespace Shop.Domain.Entities.INFPort
{
    public class CardPort
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public int? Status { get; set; }
        public int? GroupCardPortID { get; set; }
        public int? Capacity_Require { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? DeadLine { get; set; }
        public int? Capacity_Implement { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? Date_Complete { get; set; }
        public int? CapacityUnrealized { get; set; }
    }
}
