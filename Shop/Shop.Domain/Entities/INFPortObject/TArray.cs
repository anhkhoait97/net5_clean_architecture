using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TArray
    {
        public int ID { get; set; }
        public int? ValuesID { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public int? Parent { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
