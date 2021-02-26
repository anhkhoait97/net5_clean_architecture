using System;
namespace Shop.Domain.Entities.INFPort
{
    public class DSP_TC
    {
        public int ID { get; set; }
        public int? LocationID { get; set; }
        public string TCName { get; set; }
        public string Card { get; set; }
        public int? PortCard { get; set; }
        public string DSLam { get; set; }
        public int? PortTCIn { get; set; }
        public int? PortTCOut { get; set; }
        public string Contract { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
