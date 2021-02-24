using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class RackList
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Capacity { get; set; }
        public string RackSite { get; set; }
        public int? Width { get; set; }
        public int? Depth { get; set; }
        public int? Height { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}

