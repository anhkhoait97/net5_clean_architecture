using System;

namespace Shop.Domain.Entities.INFPort
{
    public class CRDevice
    {
        public long ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Asset { get; set; }
        public int? Capacity { get; set; }
        public string DeviceType { get; set; }
        public int? ManufacturerID { get; set; }
        public int? ManagerUnitID { get; set; }
        public int? Type { get; set; }
        public string Address { get; set; }
        public int? Function { get; set; }
        public string Description { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public string Link { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
