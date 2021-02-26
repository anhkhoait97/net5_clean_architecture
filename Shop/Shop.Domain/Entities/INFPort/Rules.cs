using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Rules
    {
        public int ID { get; set; }
        public int FunctionID { get; set; }
        public int GroupID { get; set; }
        public byte AUpdate { get; set; }
        public byte AInsert { get; set; }
        public byte ARemove { get; set; }
        public byte ADetail { get; set; }
    }
}
