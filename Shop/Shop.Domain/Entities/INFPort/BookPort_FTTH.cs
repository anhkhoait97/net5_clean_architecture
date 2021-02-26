using System;

namespace Shop.Domain.Entities.INFPort
{
    public class BookPort_FTTH
    {
        public int ID { get; set; }
        public long? ContractID { get; set; }
        public string Creator { get; set; }
        public string Employee { get; set; }
        public DateTime? BookDate { get; set; }
        public DateTime? ActionDate { get; set; }
        public string ParamAction { get; set; }
        public string TempContract { get; set; }
        public string AccType { get; set; }
        public string Status { get; set; }
        public int? TypeService { get; set; }
        public int? TypeBook { get; set; }
    }
}
