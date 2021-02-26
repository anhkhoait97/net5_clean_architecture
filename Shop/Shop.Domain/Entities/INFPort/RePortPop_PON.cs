using System;
namespace Shop.Domain.Entities.INFPort
{
    public class RePortPop_PON
    {
        public long ID { get; set; }
        public string LocationID { get; set; }
        public string BranchID { get; set; }
        public string BranchName { get; set; }
        public string PopName { get; set; }
        public string PopType { get; set; }
        public string Address { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string DateUser { get; set; }
        public string UpdateBy { get; set; }
        public string GFA6700 { get; set; }
        public string EL5600 { get; set; }
        public string TA5006 { get; set; }
        public string EL5600_06 { get; set; }
        public string GL5600 { get; set; }
        public string SumOLT { get; set; }
        public string SumSlot { get; set; }
        public string GFAFW { get; set; }
        public string GFAEPON { get; set; }
        public string SumCard { get; set; }
        public string SlotUser { get; set; }
        public string PortC1 { get; set; }
        public string PortC1User { get; set; }
        public string PortC1Free { get; set; }
        public string PortC2 { get; set; }
        public string PortC2User { get; set; }
        public string PortC2Free { get; set; }
        public string SlotFree { get; set; }
        public string CreateDate { get; set; }
        public int? Region { get; set; }
        public string OfficeName { get; set; }
    }
}
