using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TList
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
