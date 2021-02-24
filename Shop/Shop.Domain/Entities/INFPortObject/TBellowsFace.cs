using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TBellowsFace
    {
        public long ID { get; set; }
        public long? BellowsID { get; set; }
        public string NameFace { get; set; }
        public int? Size { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? Type { get; set; }
        public int? FaceID { get; set; }
    }
}

