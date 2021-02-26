using System;

namespace Shop.Domain.Entities.INFPort
{
    public class POP_Maintain
    {
        public int ID { get; set; }
        public long? POPID { get; set; }
        public DateTime? MDate { get; set; }
        public int? NumberMaintain { get; set; }
        public string Employee { get; set; }
        public string MaintainStatus { get; set; }
    }
}
