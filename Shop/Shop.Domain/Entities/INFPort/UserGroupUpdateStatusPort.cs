using System;
namespace Shop.Domain.Entities.INFPort
{
    public class UserGroupUpdateStatusPort
    {
        public long ID { get; set; }
        public string UserName { get; set; }
        public long? GroupID { get; set; }
    }
}
