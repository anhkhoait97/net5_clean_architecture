using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TContractHistory
    {
        public long ID { get; set; }
        public long? TContractID { get; set; }
        public DateTime? Date { get; set; }
        public string ContractName { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public string NameBranch { get; set; }
        public string TacitName { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Type { get; set; }
        public int? PartnerID { get; set; }
        public int? StatusContract { get; set; }
        public int? StatusPay { get; set; }
        public long? DocumentID { get; set; }
        public string IsFile { get; set; }
        public string Appendices { get; set; }
        public string Sum_Values_Real { get; set; }
        public string Sum_Values_Refer { get; set; }
        public int? VAT { get; set; }
        public int? Cycle_Pay { get; set; }
        public int? Number_Pay { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? HandleType { get; set; }
        public string DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int? IsPi { get; set; }
    }
}
