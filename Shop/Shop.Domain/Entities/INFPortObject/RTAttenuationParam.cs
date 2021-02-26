using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class RTAttenuationParam
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double? Attenuation { get; set; }
        public int? Type { get; set; }
        public int? Enable { get; set; }
        public int? ParentID { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
