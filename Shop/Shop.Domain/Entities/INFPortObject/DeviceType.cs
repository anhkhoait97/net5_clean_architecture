using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class DeviceType
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string DeviceTypeCode { get; set; }
        public int? TypeListID { get; set; }
        public int? VendorListID { get; set; }
        public short? SlotEX { get; set; }
        public int? NumberSlotEX { get; set; }
        public string FormatSlotEX { get; set; }
        public short? SpecialSlot { get; set; }
        public int? NumberSlotSpecial { get; set; }
        public string FormatSpecialSlot { get; set; }
        public short? UserSlot { get; set; }
        public int? NumberUserSlot { get; set; }
        public string FormatUserSlot { get; set; }
        public int? DepartmentID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? ValueInside { get; set; }
    }
}

