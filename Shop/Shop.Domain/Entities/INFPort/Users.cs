using System;

namespace Shop.Domain.Entities.INFPort
{
    public class Users
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public DateTime? Birthday { get; set; }
        public bool? Sex { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public long? Ward { get; set; }
        public long? District { get; set; }
        public long? City { get; set; }
        public string Identify { get; set; }
        public string Telephone { get; set; }
        public string HandPhone { get; set; }
        public string Email { get; set; }
        public string PicturePath { get; set; }
        public string BranchID { get; set; }
        public string LocationID { get; set; }
        public int? Sale { get; set; }
        public string Part { get; set; }
    }
}
