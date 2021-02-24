using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class RTConnectingOutside
    {
        public long ID { get; set; }
        public long? PortIn { get; set; }
        public long? PortOut { get; set; }
        public int? Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public long? ChannelID { get; set; }
        public string ChannelName { get; set; }
    }

}
