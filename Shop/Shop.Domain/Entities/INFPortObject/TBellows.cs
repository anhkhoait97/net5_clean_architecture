using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TBellows
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public long? TacitID { get; set; }
        public string Plans { get; set; }
        public long? PointConnectID { get; set; }
        public string PointConnectName { get; set; }
        public int? TypeConnect { get; set; }
        public int? ShapeBellowsID { get; set; }
        public int? ShapeLidID { get; set; }
        public int? CapacityLid { get; set; }
        public int? MaterialID { get; set; }
        public int? CapacityTube { get; set; }
        public string Size { get; set; }
        public string XCoordinate { get; set; }
        public string YCoordinate { get; set; }
        public string Street { get; set; }
        public int? District { get; set; }
        public int? Ward { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? OwnedID { get; set; }
        public DateTime? DateUse { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string DifferentName { get; set; }
        public int? TypeObject { get; set; }
        public int? TypeDevice { get; set; }
    }
}
