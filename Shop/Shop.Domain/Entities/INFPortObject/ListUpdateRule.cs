using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class ListUpdateRule
    {
        public long ID { get; set; }
        public long? ListUpdateID { get; set; }
        public int? DepartID { get; set; }
        public string DepartName { get; set; }
        public int? NumberLevel { get; set; }
        public int? Accept { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DeadLine { get; set; }
        public DateTime? FinalEndDate { get; set; }
        public int? DepartStatusID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }

}
