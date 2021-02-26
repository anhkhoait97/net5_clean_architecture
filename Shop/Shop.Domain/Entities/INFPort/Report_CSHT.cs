using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Report_CSHT
    {
        public long ID { get; set; }
        public string Location { get; set; }
        public string BranchID { get; set; }
        public string BranchName { get; set; }
        public string PopName { get; set; }
        public string TypePop { get; set; }
        public string DSLam { get; set; }
        public string DateRun { get; set; }
        public string DateUser { get; set; }
        public string SlotFree { get; set; }
        public string CableFree { get; set; }
        public string SumCard { get; set; }
        public string ALC72 { get; set; }
        public string ALC51 { get; set; }
        public string ELC { get; set; }
        public string ALC71 { get; set; }
        public string VLC { get; set; }
        public string ALC1372G { get; set; }
        public string IES1248 { get; set; }
        public string ASTEC { get; set; }
        public string SumTu { get; set; }
        public string SumBox { get; set; }
        public string MaxPop { get; set; }
        public string SumCableGoc { get; set; }
        public string SumCablePhoi { get; set; }
        public string DLUser { get; set; }
        public string PortUser { get; set; }
        public string PortFree { get; set; }
        public string CableGocFree { get; set; }
        public string CablePhoiFree { get; set; }
        public string PercentCableGoc { get; set; }
        public string PercentCablePhoi { get; set; }
        public string MaxPercent { get; set; }
        public string PercentCard { get; set; }
        public string Adress { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string CreateDate { get; set; }
        public int? Region { get; set; }
    }
}
