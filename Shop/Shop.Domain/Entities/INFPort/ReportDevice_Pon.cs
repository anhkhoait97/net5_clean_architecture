using System;
namespace Shop.Domain.Entities.INFPort
{
    public class ReportDevice_Pon
    {
        public long ID { get; set; }
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
        public string SumSplitter1 { get; set; }
        public string SumSplitter2 { get; set; }
        public string SumportLV1 { get; set; }
        public string SumportLV1Setup { get; set; }
        public string SumportLV1SetUpUser { get; set; }
        public string SumportLV1SetUpFree { get; set; }
        public string PencentLV1 { get; set; }
        public string SumportLV2 { get; set; }
        public string SumportLV2Setup { get; set; }
        public string SumportLV2SetupUser { get; set; }
        public string SumportlV2SetupFree { get; set; }
        public string PencentLV2 { get; set; }
        public string SumportLV1Die { get; set; }
        public string SumportLV2Mantant { get; set; }
        public string SumportLV2Die { get; set; }
        public string ParenName { get; set; }
        public string Plant { get; set; }
        public string Equipment { get; set; }
        public string NameManuface { get; set; }
        public string ProductName { get; set; }
        public string Address { get; set; }
        public string DateUse { get; set; }
        public string ActiveDate { get; set; }
        public string UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string CreateDate { get; set; }
        public int? Region { get; set; }
        public string Length { get; set; }
        public long? IDPop { get; set; }
        public string SumportLV2SetupCard { get; set; }
        public string BuildingName { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
    }
}
