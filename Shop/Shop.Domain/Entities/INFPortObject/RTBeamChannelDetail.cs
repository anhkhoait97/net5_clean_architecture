using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class RTBeamChannelDetail
    {
        public long ID { get; set; }
        public long? ParentID { get; set; }
        public long? ChildID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? Type { get; set; }
    }
}

