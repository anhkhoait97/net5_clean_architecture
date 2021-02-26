namespace Shop.Domain.Entities.INFPort
{
    public class ReportModuleDeviceTemporary
    {
        public long ID { get; set; }
        public string STT { get; set; }
        public string Branch { get; set; }
        public string POPID { get; set; }
        public string DeviceType { get; set; }
        public string Model { get; set; }
        public string DeviceName { get; set; }
        public string CardName { get; set; }
        public string CardType { get; set; }
        public string Port { get; set; }
        public string UsePort { get; set; }
        public string ModuleType { get; set; }
        public string Capacity { get; set; }
        public string Status { get; set; }
        public string Core { get; set; }
        public string Distance { get; set; }
        public string ReceivedPower { get; set; }
        public string GivenPower { get; set; }
    }
}
