using System;

namespace Shop.Domain.Entities.INFPort
{
    public class TRouteLink
    {
        public long ID { get; set; }
        public long? RouteTubeID { get; set; }
        public long? TubeID { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
