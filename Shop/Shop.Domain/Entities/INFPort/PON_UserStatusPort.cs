using System;
namespace Shop.Domain.Entities.INFPort
{
    public class PON_UserStatusPort
    {
        public long ID { get; set; }
        public string UserName { get; set; }
        public long? GroupID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
