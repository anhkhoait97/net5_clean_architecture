using System;
namespace Shop.Domain.Entities.INFPort
{
    public class TD
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public byte? Level { get; set; }
        public int? Capacity { get; set; }
        public string AddNumber { get; set; }
        public string Street { get; set; }
        public long? Ward { get; set; }
        public long? District { get; set; }
        public long? City { get; set; }
        public int? Status { get; set; }
        public byte? Confrm { get; set; }
        public int? Length { get; set; }
        public int? OutdoorLimit { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? TypeBuilding { get; set; }
        public int? BuildingID { get; set; }
        public string BuildingName { get; set; }
        public string Plans { get; set; }
        public string Lot { get; set; }
        public int? Floor { get; set; }
        public int? Investment { get; set; }
        public int? CardNumberStart { get; set; }
        public int? TypeDevice { get; set; }
        public int? TypePort { get; set; }
        public DateTime? BookDate { get; set; }
        public string AccountImport { get; set; }
        public string PopTD { get; set; }
        public int? InvestCapacity { get; set; }
        public int? ElectListID { get; set; }
        public DateTime? StatusDate { get; set; }
    }
}
