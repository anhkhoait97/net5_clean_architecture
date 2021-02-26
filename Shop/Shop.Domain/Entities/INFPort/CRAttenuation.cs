using System;
namespace Shop.Domain.Entities.INFPort
{
    public class CRAttenuation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Value { get; set; }
        public byte Type { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
