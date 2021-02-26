using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class RTBeamChannel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public int? TypeINFID { get; set; }
        public int? FunctionID { get; set; }
        public int? iStackID { get; set; }
        public int? DiagramID { get; set; }
        public int? TypeBeam { get; set; }
        public int? TypeBeamDetail { get; set; }
        public int? LevelID { get; set; }
        public int? LocationDeviceBeam1 { get; set; }
        public string BranchDeviceBeam1 { get; set; }
        public string DeviceName1 { get; set; }
        public int? TypeDevice1 { get; set; }
        public int? LocationDeviceBeam2 { get; set; }
        public string BranchDeviceBeam2 { get; set; }
        public string DeviceName2 { get; set; }
        public int? TypeDevice2 { get; set; }
        public string Description { get; set; }
        public int? UnitManagementID { get; set; }
        public int? UnitUserID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? DateUse { get; set; }
        public long? PopDevice1 { get; set; }
        public long? PopDevice2 { get; set; }
    }
}
