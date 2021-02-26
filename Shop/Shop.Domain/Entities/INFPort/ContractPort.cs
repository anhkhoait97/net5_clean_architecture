using System;

namespace Shop.Domain.Entities.INFPort
{
    public class ContractPort
    {
        public int ID { get; set; }
        public string Contract { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? LocationID { get; set; }
        public string Parameter { get; set; }
        public int? Type { get; set; }
    }
}
