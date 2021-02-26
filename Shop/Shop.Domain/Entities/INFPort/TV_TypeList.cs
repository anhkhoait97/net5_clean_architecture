using System;
namespace Shop.Domain.Entities.INFPort
{
    public class TV_TypeList
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? PortIn { get; set; }
        public int? PortOut { get; set; }
        public string Power { get; set; }
        public int? Type { get; set; }
    }
}
