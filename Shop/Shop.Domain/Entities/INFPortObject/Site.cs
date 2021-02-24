using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class Site
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string PlanCode { get; set; }
        public string Address { get; set; }
        public int? District { get; set; }
        public int? Ward { get; set; }
        public string Description { get; set; }
        public string Xcoordinate { get; set; }
        public string Ycoordinate { get; set; }
        public string GISID { get; set; }
        public string UserBy { get; set; }
        public string Contacts { get; set; }
        public int? DepartmentID { get; set; }
        public int? LocationID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string ObjectType { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string INFMaintain { get; set; }
    }
}

