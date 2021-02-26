using System;
namespace Shop.Domain.Entities.INFPort
{
    public class API_DeviceAccess
    {
        public long ID { get; set; }
        public string Branch { get; set; }
        public string Type { get; set; }
        public string DeviceType { get; set; }
        public string OldIP { get; set; }
        public string NewIP { get; set; }
        public string Location { get; set; }
        public string OldMainDepart { get; set; }
        public string NewMainDepart { get; set; }
        public string RingName { get; set; }
        public string CardName { get; set; }
        public int? Portmax { get; set; }
        public string SlotName { get; set; }
        public int? SlotNo { get; set; }
        public int? SlotMax { get; set; }
        public string OldName { get; set; }
        public string NewName { get; set; }
        public string OldStatus { get; set; }
        public string NewStatus { get; set; }
        public int? Action { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? Flag { get; set; }
        public string Description { get; set; }
        public long? LocationID { get; set; }
        public string GroupDevice { get; set; }
    }
}
