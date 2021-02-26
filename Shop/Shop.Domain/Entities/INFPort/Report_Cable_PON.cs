using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Report_Cable_PON
    {
        public long ID { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public string BranchName { get; set; }
        public string PopName { get; set; }
        public string Name { get; set; }
        public string Capacity { get; set; }
        public string PortUser { get; set; }
        public string PortFree { get; set; }
        public string PortDie { get; set; }
        public string CoreUser { get; set; }
        public string CoreHu { get; set; }
        public string CoreDie { get; set; }
        public string Type { get; set; }
        public string StartName { get; set; }
        public string EndName { get; set; }
        public string Length { get; set; }
        public string StartLength { get; set; }
        public string EndLength { get; set; }
        public string Method { get; set; }
        public string Plans { get; set; }
        public string Equipment { get; set; }
        public string Manufacture { get; set; }
        public string ProductName { get; set; }
        public string ManagerUnit { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string Region { get; set; }
        public string TypeCable { get; set; }
    }
}
