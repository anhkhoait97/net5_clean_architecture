using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class Rack
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? RackTypeID { get; set; }
        public string Xcoordinate { get; set; }
        public string Ycoordinate { get; set; }
        public string Zcoordinate { get; set; }
        public long? RoomID { get; set; }
        public string UserBy { get; set; }
        public string Contacts { get; set; }
        public int? DepartmentID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public long? SiteID { get; set; }
        public long? LocationID { get; set; }
        public string ObjectType { get; set; }
        public string Status { get; set; }
        public int? OnRailNumber { get; set; }
        public int? OnRailIndexingNumber { get; set; }
    }
}
