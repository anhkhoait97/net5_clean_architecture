using System;

namespace Shop.Domain.Entities.INFPort
{
    public class TC_FTTH
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AddNumber { get; set; }
        public string Street { get; set; }
        public int? Ward { get; set; }
        public int? District { get; set; }
        public long LocationID { get; set; }
        public int? Status { get; set; }
        public int? Length { get; set; }
        public int? Type { get; set; }
        public int TypeBuilding { get; set; }
        public int? BuildingID { get; set; }
        public string BuildingName { get; set; }
        public int? Floor { get; set; }
        public string Lot { get; set; }
        public string Plans { get; set; }
        public int? Capacity { get; set; }
        public int? FirstFibers { get; set; }
        public int? First_Type { get; set; }
        public int? SecondFibers { get; set; }
        public int? Second_Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string PopTC_FTTH { get; set; }
    }
}
