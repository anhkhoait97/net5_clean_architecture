using System;

namespace Shop.Domain.Entities.INFPort
{
    public class CRPurpose
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
