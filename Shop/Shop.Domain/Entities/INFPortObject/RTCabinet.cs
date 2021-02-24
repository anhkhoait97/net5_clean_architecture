using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class RTCabinet
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? TypeINFID { get; set; }
        public int? LocationID { get; set; }
        public int? FunctionID { get; set; }
        public int? TypeConnectID { get; set; }
        public int? Capacity { get; set; }
        public int? ManagerUnitID { get; set; }
        public string Address { get; set; }
        public int? DistrictID { get; set; }
        public int? WardID { get; set; }
        public string Description { get; set; }
        public int? StatusID { get; set; }
        public string Plans { get; set; }
        public string LinkDesign { get; set; }
        public string OldName { get; set; }
        public DateTime? DateUse { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string Coordinate { get; set; }
    }
}

