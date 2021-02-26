using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Pillar
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public string Height { get; set; }
        public string Description { get; set; }
        public int? ElectricID { get; set; }
        public int? ManagerUnitID { get; set; }
        public string Owner { get; set; }
        public long? StreetID { get; set; }
        public long? Ward { get; set; }
        public long? District { get; set; }
        public long? LocationID { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? BranchID { get; set; }
        public string ParentName { get; set; }
        public int? FunctionID { get; set; }
        public int? VoltageID { get; set; }
        public int? MaterialID { get; set; }
        public int? ShapeID { get; set; }
        public int? Status { get; set; }
        public string Distance { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string AddNumber { get; set; }
        public int? TypePillarID { get; set; }
        public string ODCCableType { get; set; }
        public string Code { get; set; }
        public string IsCableHang { get; set; }
        public string IsTransformers { get; set; }
        public string IsPipe { get; set; }
        public string IsManchon { get; set; }
        public string PillarPop { get; set; }
        public string Pop { get; set; }
        public string Cabinet { get; set; }
        public string DistributionPoint { get; set; }
        public int TypePortMap { get; set; }
        public string Street { get; set; }
    }
}
