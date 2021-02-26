using System;

namespace Shop.Domain.Entities.INFPort
{
    public class CPList
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? IDTypeWork { get; set; }
        public int? IDDetailWork { get; set; }
        public int? IDGroupCardPort { get; set; }
        public int? Status { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? DealLine { get; set; }
        public string Plans { get; set; }
        public string FileSave { get; set; }
        public string Design { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? Date_Complete { get; set; }
        public string IDGroupCC { get; set; }
        public string Path { get; set; }
        public int? StatusOLT { get; set; }
        public int? StatusRing { get; set; }
        public long? LocationID { get; set; }
        public int? CountUpdate { get; set; }
        public string EmailCreate { get; set; }
        public string EmailUpdate { get; set; }
        public string MonitoringName { get; set; }
        public double? KmCable { get; set; }
        public int? Capacity { get; set; }
    }
}
