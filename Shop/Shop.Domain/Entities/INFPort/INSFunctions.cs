using System;

namespace Shop.Domain.Entities.INFPort
{
    public class INSFunctions
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public byte Visible { get; set; }
        public string RefPath { get; set; }
        public int Parent { get; set; }
        public byte Type { get; set; }
        public short Level { get; set; }
        public short Level_1 { get; set; }
        public string Param { get; set; }
        public int? IsType { get; set; }
        public string RefPathNew { get; set; }
    }
}
