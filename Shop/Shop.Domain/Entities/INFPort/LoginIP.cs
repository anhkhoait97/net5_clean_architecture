using System;
namespace Shop.Domain.Entities.INFPort
{
    public class LoginIP
    {
        public long ID { get; set; }
        public string UserName { get; set; }
        public string IPAddress { get; set; }
        public DateTime? DateLogIn { get; set; }
        public string UserID { get; set; }
    }
}
