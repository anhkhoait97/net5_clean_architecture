using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TRouteCableLink
    {
        public int ID { get; set; }
        public long? BellowID { get; set; }
        public string DataArray { get; set; }
        public string DataLink { get; set; }
        public int? Length { get; set; }
        public string Custom { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}

