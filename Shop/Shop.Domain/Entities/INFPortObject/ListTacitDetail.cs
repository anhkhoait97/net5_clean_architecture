using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class ListTacitDetail
    {
        public int ID { get; set; }
        public int? ListTacitID { get; set; }
        public int? WorkID { get; set; }
        public int? TimelineFTQ { get; set; }
        public int? TimelineINF { get; set; }
        public int? TimelineKH { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
