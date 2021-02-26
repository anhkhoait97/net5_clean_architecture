using System;
namespace Shop.Domain.Entities.INFPort
{
    public class CRPurpose_Log
    {
        public long ID_Log { get; set; }
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Layer { get; set; }
        public long? ISP_RingID { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string Action { get; set; }
        public string ActionBy { get; set; }
        public DateTime ActionDate { get; set; }
    }
}
