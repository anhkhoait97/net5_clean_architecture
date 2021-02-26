using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class RTODF
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? FunctionID { get; set; }
        public int? TypeConnectID { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public long? PopID { get; set; }
        public int? Capacity { get; set; }
        public int? ManagerUnitID { get; set; }
        public long? RackID { get; set; }
        public DateTime? DateUse { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string Description { get; set; }
    }
}
