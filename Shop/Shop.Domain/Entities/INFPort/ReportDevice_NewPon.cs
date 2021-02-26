using System;
namespace Shop.Domain.Entities.INFPort
{
    public class ReportDevice_NewPon
    {
        public long ID { get; set; }
        public int? Region { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public string BranchName { get; set; }
        public string PopName { get; set; }
        public string Name { get; set; }
        public string DeviceType { get; set; }
        public string Technogoly { get; set; }
        public string Method { get; set; }
        public string Connect { get; set; }
        public string Function { get; set; }
        public int? SumSplitter1 { get; set; }
        public int? SumSplitter2 { get; set; }
        public int? SumportLV1 { get; set; }
        public int? SumportLV1Setup { get; set; }
        public int? SumportLV1SetUpUser { get; set; }
        public int? SumportLV1SetUpFree { get; set; }
        public double? PencentLV1 { get; set; }
        public int? SumportLV2 { get; set; }
        public int? SumportLV2Setup { get; set; }
        public int? SumportLV2SetupUser { get; set; }
        public int? SumportlV2SetupFree { get; set; }
        public double PencentLV2 { get; set; }
        public int? SumPort3 { get; set; }
        public int? SumPort3Con { get; set; }
        public int? SumPort3ConUse { get; set; }
        public int? SumPort3ConFree { get; set; }
        public double? Percent3 { get; set; }
        public int? SumportLV1Die { get; set; }
        public int? SumportLV2Die { get; set; }
        public int? SumportLV2Mantant { get; set; }
        public string TypeHDN { get; set; }
        public int? EfficiencyID { get; set; }
        public string Efficiency { get; set; }
        public string ParenName { get; set; }
        public string Plans { get; set; }
        public string Equipment { get; set; }
        public string NameManuface { get; set; }
        public string ProductName { get; set; }
        public string Address { get; set; }
        public DateTime? DateUse { get; set; }
        public double? ActiveDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string Length { get; set; }
        public int? TypeBuilding { get; set; }
        public string BuildingName { get; set; }
        public long? WardID { get; set; }
        public long? DistrictID { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public int? DayCreate { get; set; }
        public int? MonthCreate { get; set; }
        public int? YearCreate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string LeaseLineFlag { get; set; }
    }
}
