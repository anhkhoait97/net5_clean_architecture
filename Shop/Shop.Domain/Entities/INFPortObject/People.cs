using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class People
    {
        public long ID { get; set; }
        public string Describe { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string StaffCode { get; set; }
        public int? Status { get; set; }
        public int? Flag { get; set; }
        public long? PeopleID { get; set; }
        public int? ServiceIT { get; set; }
        public int? LocationID { get; set; }
        public int? Position { get; set; }
        public string LevelStaff { get; set; }
        public string Diploma { get; set; }
        public string Schools { get; set; }
        public string Certificate { get; set; }
        public DateTime? DateIn { get; set; }
        public DateTime? DateSign { get; set; }
        public DateTime? DateSignNext { get; set; }
        public string DateEnd { get; set; }
        public int? TypeContract { get; set; }
        public string ChangeRequest { get; set; }
        public long? Salary { get; set; }
        public long? DeviceID { get; set; }
        public string Version { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
