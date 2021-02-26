using System;

namespace Shop.Domain.Entities.INFPort
{
    public class ConditionSwitch
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? Port { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
