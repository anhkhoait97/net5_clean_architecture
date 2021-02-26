using System;
namespace Shop.Domain.Entities.INFPort
{
    public class ReportContract
    {
        public int ID { get; set; }
        public string LocationID { get; set; }
        public string Branch { get; set; }
        public string Pop { get; set; }
        public string TypeContract { get; set; }
        public string TypeRePort { get; set; }
        public string Type { get; set; }
        public string DSLam { get; set; }
        public string TCName { get; set; }
        public string TDName { get; set; }
        public string Card_Switch { get; set; }
        public string ContracID { get; set; }
        public string ODCCableType { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string LasUpdateBy { get; set; }
    }
}
