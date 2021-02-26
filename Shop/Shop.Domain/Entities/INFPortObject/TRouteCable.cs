using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TRouteCable
    {
        public long ID { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public int? Type { get; set; }
        public int? PartnerNameID { get; set; }
        public int? TypeCable { get; set; }
        public int? Capacity { get; set; }
        public int? TypeDevice { get; set; }
        public string DeviceName { get; set; }
        public long? DeviceID { get; set; }
        public string CableName { get; set; }
        public long? CableID { get; set; }
        public string Description { get; set; }
        public long? TacitID { get; set; }
        public string TacitName { get; set; }
        public int? TypeObject { get; set; }
        public string NameObject { get; set; }
        public string EndName { get; set; }
        public string ODCCableType { get; set; }
        public string CableLength { get; set; }
        public int? Direction { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? PiFullFlag { get; set; }
        public long? ContractID { get; set; }
        public int? FullPiSize { get; set; }
        public long? LocationCable { get; set; }
        public long? BranchCable { get; set; }
        public int? Status { get; set; }
        public DateTime? DateUse { get; set; }
        public int? TypeCount { get; set; }
    }
}
