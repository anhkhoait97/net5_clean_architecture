using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TDocument
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public string NameBranch { get; set; }
        public int? Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string IsFile { get; set; }
        public int? Extension { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
