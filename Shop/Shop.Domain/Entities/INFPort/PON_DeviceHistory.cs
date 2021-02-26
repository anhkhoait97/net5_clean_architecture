using System;
namespace Shop.Domain.Entities.INFPort
{
    public class PON_DeviceHistory
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public int? Type { get; set; }
        public long? DeviceID { get; set; }
        public string TypeDevice { get; set; }
        public string Method { get; set; }
        public string Connect { get; set; }
        public string Function { get; set; }
        public int? Number1 { get; set; }
        public int? Number2 { get; set; }
        public int? Capacity1 { get; set; }
        public int? Install_Capacity1 { get; set; }
        public int? Install_Capacity1_Use { get; set; }
        public int? Install_Capacity1_Free { get; set; }
        public int? Ratio_Percen1 { get; set; }
        public int? Capacity2 { get; set; }
        public int? Install_Capacity2 { get; set; }
        public int? Install_Capacity2_Use { get; set; }
        public int? Install_Capacity2_Free { get; set; }
        public int? Ratio_Percen2 { get; set; }
        public int? PortDie1 { get; set; }
        public int? Number2_Mainten { get; set; }
        public int? PortDie2 { get; set; }
        public string ParentName { get; set; }
        public string Plans { get; set; }
        public string Equipment { get; set; }
        public string Manufacture { get; set; }
        public string ProductName { get; set; }
        public string Address { get; set; }
        public DateTime? DateUse { get; set; }
        public int? UpTime { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
