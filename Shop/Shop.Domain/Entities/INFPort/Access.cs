using System;

namespace Shop.Domain.Entities.INFPort
{
    public class Access
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public string Address { get; set; }
        public int? DistrictID { get; set; }
        public int? WardID { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? Capacity { get; set; }
        public int? LocationID { get; set; }
        public int? TypeGateway { get; set; }
        public int? GatewayID { get; set; }
        public long? PortID { get; set; }
        public int? Length { get; set; }
        public int? TypeBuilding { get; set; }
        public int? BuildingID { get; set; }
        public string BuildingName { get; set; }
        public string Plans { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? Level { get; set; }
        public int? InvestCapacity { get; set; }
    }
}
