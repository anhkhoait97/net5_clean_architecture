using System;
namespace Shop.Domain.Entities.INFPort
{
    public class TC_FTTHLink
    {
        public long ID { get; set; }
        public long? TC_ID { get; set; }
        public long? TD_ID { get; set; }
        public int? Capacity { get; set; }
        public int? FromCore { get; set; }
        public int? ToCore { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
