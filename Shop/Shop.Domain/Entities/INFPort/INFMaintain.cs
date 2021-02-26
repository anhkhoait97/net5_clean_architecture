using System;
namespace Shop.Domain.Entities.INFPort
{
    public class INFMaintain
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long? BranchID { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? LocationID { get; set; }
        public string Email { get; set; }
    }
}
