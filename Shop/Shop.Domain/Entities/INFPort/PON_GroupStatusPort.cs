using System;
namespace Shop.Domain.Entities.INFPort
{
    public class PON_GroupStatusPort
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long? LocationID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
