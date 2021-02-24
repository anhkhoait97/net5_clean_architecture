using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class RTConnecting
    {
        public long ID { get; set; }
        public long? PortIn { get; set; }
        public string PortConnectIn { get; set; }
        public string DeviceNameIn { get; set; }
        public string ConnectorIn { get; set; }
        public string DeviceName { get; set; }
        public long? PortOut { get; set; }
        public string PortConnectOut { get; set; }
        public string DeviceNameOut { get; set; }
        public string ConnectorOut { get; set; }
        public long? ChannelID { get; set; }
        public string ChannelName { get; set; }
        public int? TypeDirection { get; set; }
        public int? Type { get; set; }
        public string Generic { get; set; }
        public string Length { get; set; }
        public long? ConnectID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? TypeConnect { get; set; }
        public int? TypeCore { get; set; }
    }
}

