using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class CMList
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? indexR { get; set; }
    }
}
