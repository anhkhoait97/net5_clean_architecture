using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class THistoryWithDraw
    {
        public long ID { get; set; }
        public long? LocationID { get; set; }
        public string BranchID { get; set; }
        public string TacitName { get; set; }
        public string DeviceName { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string IP { get; set; }
    }

}
