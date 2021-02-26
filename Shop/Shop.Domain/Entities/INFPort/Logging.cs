using System;

namespace Shop.Domain.Entities.INFPort
{
    public class Logging
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string IPAddress { get; set; }
        public string OwnerName { get; set; }
        public long? LocationID { get; set; }
        public string BranchID { get; set; }
        public string Action { get; set; }
        public string DeviceName { get; set; }
        public long ContractID { get; set; }
        public string Data { get; set; }
    }
}
