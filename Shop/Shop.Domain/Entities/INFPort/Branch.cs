using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Branch
    {
        public int ID { get; set; }
        public string NameBranch { get; set; }
        public string LocationID { get; set; }
        public string Parent { get; set; }
        public int? BranchCode { get; set; }
        public string ListMail { get; set; }
    }
}
