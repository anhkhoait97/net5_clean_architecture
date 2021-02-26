using System;
namespace Shop.Domain.Entities.INFPort
{
    public class BookPort
    {
        public int ID { get; set; }
        public long? ContractID { get; set; }
        public string ContractTemp { get; set; }
        public string Passport { get; set; }
        public string Pop { get; set; }
        public string CardName { get; set; }
        public int? PortCard { get; set; }
        public string MDFName { get; set; }
        public int? PortMDF { get; set; }
        public string TCName { get; set; }
        public int? PortTCIn { get; set; }
        public int? PortTCOut { get; set; }
        public string TDName { get; set; }
        public int? PortTD { get; set; }
        public DateTime? BookDate { get; set; }
        public string CreateBy { get; set; }
        public long? LocationID { get; set; }
        public int? BranchID { get; set; }
        public int? Type { get; set; }
        public int? Flag { get; set; }
        public string SaleName { get; set; }
        public int? TypeBook { get; set; }
        public string BookDay { get; set; }
    }
}
