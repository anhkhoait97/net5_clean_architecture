using System;
namespace Shop.Domain.Entities.INFPort
{
    public class EOCTap
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? Capacity { get; set; }
        public int? Length { get; set; }
        public int? Status { get; set; }
        public string Description { get; set; }
        public long? EOCMasterID { get; set; }
        public string Street { get; set; }
        public long? WardID { get; set; }
        public long? DistrictID { get; set; }
        public long? LocationID { get; set; }
        public long? BranchID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? TypeBuilding { get; set; }
        public int? BuildingID { get; set; }
        public string BuildingName { get; set; }
        public int? InvestCapacity { get; set; }
    }
}
