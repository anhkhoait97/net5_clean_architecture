using System;
namespace Shop.Domain.Entities.INFPort
{
    public class RulesPartner
    {
        public long ID { get; set; }
        public string UserID { get; set; }
        public int FunctionID { get; set; }
        public bool? IsInsert { get; set; }
        public bool? IsUpdate { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsDetail { get; set; }
    }
}
