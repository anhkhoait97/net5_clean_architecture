using System;

namespace Shop.Domain.Entities.INFPort
{
    public class ConnectingHistory
    {
        public int ID { get; set; }
        public string Contract { get; set; }
        public string TDOld { get; set; }
        public int? PortTDOld { get; set; }
        public string TDNew { get; set; }
        public int? PortTDNew { get; set; }
        public DateTime? DateUse { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
    }
}
