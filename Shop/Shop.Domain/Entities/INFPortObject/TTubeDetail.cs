using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TTubeDetail
    {
        public long ID { get; set; }
        public int? Type { get; set; }
        public string Name { get; set; }
        public long? DeviceID { get; set; }
        public int? Number { get; set; }
        public int? Capacity { get; set; }
        public int? SiteID { get; set; }
        public int? TypeTube { get; set; }
        public int? Status { get; set; }
        public int? MaterialID { get; set; }
        public int? ColorID { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? PiFullFlag { get; set; }
        public string CoordinatesXSectionStart { get; set; }
        public string CoordinatesYSectionStart { get; set; }
        public string CoordinatesXSectionEnd { get; set; }
        public string CoordinatesYSectionEnd { get; set; }
    }
}
