using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TTube
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public long? TacitID { get; set; }
        public string Plans { get; set; }
        public int? StartConnectType { get; set; }
        public long? StartDeviceID { get; set; }
        public string StartDeviceName { get; set; }
        public int? EndConnectType { get; set; }
        public long? EndDeviceID { get; set; }
        public string EndDeviceName { get; set; }
        public int? Capacity { get; set; }
        public string Length { get; set; }
        public int? OwnedID { get; set; }
        public DateTime? DateUse { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? EndBranchID { get; set; }
        public long? EndTacitID { get; set; }
        public int? Type { get; set; }
        public int? TubeType { get; set; }
        public string PopName { get; set; }
        public int? StartFaceID { get; set; }
        public int? EndFaceID { get; set; }
    }

}
