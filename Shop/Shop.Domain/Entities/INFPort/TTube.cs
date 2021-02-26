using System;
namespace Shop.Domain.Entities.INFPort
{
    public class TTube
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public int? Shape { get; set; }
        public string Diameter { get; set; }
        public int? Length { get; set; }
        public string Color { get; set; }
        public int? LocationID { get; set; }
        public long? StartPointID { get; set; }
        public long? EndPointID { get; set; }
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
        public string Plans { get; set; }
    }
}
