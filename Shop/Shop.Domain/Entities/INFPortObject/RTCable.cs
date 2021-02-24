using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class RTCable
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? TypeINFID { get; set; }
        public int? LocationID { get; set; }
        public string BranchID { get; set; }
        public int? TypeModeID { get; set; }
        public int? Capacity { get; set; }
        public int? ManagerUnitID { get; set; }
        public string Length { get; set; }
        public int? AttenuationID { get; set; }
        public string StartLength { get; set; }
        public string EndLength { get; set; }
        public string RealLength { get; set; }
        public int? LocationDevice1 { get; set; }
        public string BranchDevice1 { get; set; }
        public string DeviceName1 { get; set; }
        public int? TypeDevice1 { get; set; }
        public int? LocationDevice2 { get; set; }
        public string BranchDevice2 { get; set; }
        public string DeviceName2 { get; set; }
        public int? TypeDevice2 { get; set; }
        public int? StatusID { get; set; }
        public string Plans { get; set; }
        public string LinkDesign { get; set; }
        public string OldName { get; set; }
        public int? MethodID { get; set; }
        public DateTime? DateUse { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? TypeCable { get; set; }
    }

}
