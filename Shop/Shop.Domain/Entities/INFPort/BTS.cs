using System;

namespace Shop.Domain.Entities.INFPort
{
    public class BTS
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int? District { get; set; }
        public int? Ward { get; set; }
        public int Type { get; set; }
        public int? ElectricID { get; set; }
        public int? LocationID { get; set; }
        public int? Capacity { get; set; }
        public string Config { get; set; }
        public int? BranchID { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? IsType { get; set; }
    }
}
