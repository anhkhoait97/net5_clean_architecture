using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class ListUpdate
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? LocationID { get; set; }
        public int? DepartmentID { get; set; }
        public int? TypeTacit { get; set; }
        public int? TypeWorkID { get; set; }
        public int? StatusID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Plans { get; set; }
        public string LinkFile { get; set; }
        public string Designed { get; set; }
        public string Description { get; set; }
        public int? IsOLT { get; set; }
        public int? IsRing { get; set; }
        public string Monitored { get; set; }
        public string NumberKm { get; set; }
        public int? Capacity { get; set; }
        public int? CapacityTD { get; set; }
        public string Requested { get; set; }
        public string Email { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string AttachedFilePath { get; set; }
        public string Construction_POP { get; set; }
    }
}
