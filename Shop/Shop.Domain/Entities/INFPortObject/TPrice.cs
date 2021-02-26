using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TPrice
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public string NameBranch { get; set; }
        public long? TDocumentID { get; set; }
        public int? Formality_Rent { get; set; }
        public string Diameter { get; set; }
        public int? Unit { get; set; }
        public string Price { get; set; }
        public int? Type { get; set; }
        public int? Position { get; set; }
        public string Size { get; set; }
        public int? Capacity { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string PenaltPrice { get; set; }
    }
}
