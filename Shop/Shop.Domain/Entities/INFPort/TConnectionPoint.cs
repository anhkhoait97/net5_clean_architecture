using System;

namespace Shop.Domain.Entities.INFPort
{
    public class TConnectionPoint
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? Type_Pit { get; set; }
        public int? Shape_Pit { get; set; }
        public int? Shape_Cap { get; set; }
        public int? Type_Cap { get; set; }
        public int? Capacity { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public int? ManagerUnitID { get; set; }
        public string Address { get; set; }
        public int? DistrictID { get; set; }
        public int? WardID { get; set; }
        public string Description { get; set; }
        public DateTime? DateUse { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string Depth { get; set; }
        public int? IDProject { get; set; }
        public int? Pi114 { get; set; }
        public int? Pi110 { get; set; }
        public int? Pi90 { get; set; }
        public int? Pi56 { get; set; }
        public int? Pi42 { get; set; }
        public int? Pi34 { get; set; }
        public string Plans { get; set; }
        public string ProjectName { get; set; }
    }
}
