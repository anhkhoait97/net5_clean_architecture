using System;

namespace Shop.Domain.Entities.INFPort
{
    public class POP
    {
        public long ID { get; set; }
        public string PopName { get; set; }
        public string Description { get; set; }
        public string AddNumber { get; set; }
        public string Street { get; set; }
        public long? Ward { get; set; }
        public long? District { get; set; }
        public long? City { get; set; }
        public DateTime? DateUse { get; set; }
        public int? StatusID { get; set; }
        public int? Type { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Manager { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? TypeBuilding { get; set; }
        public int? BuildingID { get; set; }
        public string BuildingName { get; set; }
        public int? LengthJ { get; set; }
        public string Plans { get; set; }
        public int? CapacityRJ { get; set; }
        public string Lot { get; set; }
        public int? Floor { get; set; }
        public int? Investment { get; set; }
        public int? TypeDevice { get; set; }
        public string FunctionPop { get; set; }
        public string INFMaintain { get; set; }
        public string Xcoordinate { get; set; }
        public string Ycoordinate { get; set; }
        public string GISID { get; set; }
        public int? DepartmentID { get; set; }
        public string UserBy { get; set; }
        public int? OfficeID { get; set; }
        public string OfficeName { get; set; }
    }
}
