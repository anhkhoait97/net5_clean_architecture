using System;
namespace Shop.Domain.Entities.INFPort
{
    public class TC
    {
        public long ID { get; set; }
        public string MaTC { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public int? Capacity { get; set; }
        public string AddNumber { get; set; }
        public string Street { get; set; }
        public long? Ward { get; set; }
        public long? District { get; set; }
        public long? City { get; set; }
        public int? Status { get; set; }
        public long? CardID { get; set; }
        public byte? Confrm { get; set; }
        public int? Length { get; set; }
        public int? Type { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? TypeBuilding { get; set; }
        public int? BuildingID { get; set; }
        public string BuildingName { get; set; }
        public string Plans { get; set; }
        public string Lot { get; set; }
        public int? Floor { get; set; }
        public int? Investment { get; set; }
        public int? TypeDevice { get; set; }
        public string PopTC { get; set; }
    }
}
