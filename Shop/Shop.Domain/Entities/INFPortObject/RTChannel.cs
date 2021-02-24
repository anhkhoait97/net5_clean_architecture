using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class RTChannel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public int? TypeINFID { get; set; }
        public int? FunctionID { get; set; }
        public int? BandWidthID { get; set; }
        public int? TypeChannel { get; set; }
        public int? TypeChannelDetail { get; set; }
        public int? LevelID { get; set; }
        public int? LocationDevice1 { get; set; }
        public string BranchDevice1 { get; set; }
        public long? DevicePort1 { get; set; }
        public string DeviceName1 { get; set; }
        public int? TypeDevice1 { get; set; }
        public long? DevicePortID1 { get; set; }
        public int? LocationDevice2 { get; set; }
        public string BranchDevice2 { get; set; }
        public long? DevicePort2 { get; set; }
        public string DeviceName2 { get; set; }
        public int? TypeDevice2 { get; set; }
        public long? DevicePortID2 { get; set; }
        public string Description { get; set; }
        public int? UnitManagementID { get; set; }
        public int? UnitUserID { get; set; }
        public DateTime? DateUse { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public long? PopDevice1 { get; set; }
        public long? PopDevice2 { get; set; }
        public double? RealAttenuation { get; set; }
        public double? TheoryAttenuation { get; set; }
        public int? CountManchon { get; set; }
        public int? CountPopDN { get; set; }
        public double? CountLengthCable { get; set; }
    }
}

