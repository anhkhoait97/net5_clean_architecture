using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class LocationContact
    {
        public long ID { get; set; }
        public string Owner { get; set; }
        public string UserBy { get; set; }
        public string LastUpdateBy { get; set; }
        public string Contacts { get; set; }
        public long? SiteID { get; set; }
        public long? RoomID { get; set; }
        public long? RackID { get; set; }
        public string SystemLocation { get; set; }
        public int? DepartmentID { get; set; }
        public long? ManagermentID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}

