using System;
namespace Shop.Domain.Entities.INFPort
{
    public class ListMail
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public int? DepartmentId { get; set; }
        public long? BranchID { get; set; }
        public long? LocationID { get; set; }
        public int? Type { get; set; }
        public int? GroupCardPortID { get; set; }
        public string TypeMail { get; set; }
    }
}
