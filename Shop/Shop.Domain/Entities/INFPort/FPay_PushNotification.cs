using System;
namespace Shop.Domain.Entities.INFPort
{
    public class FPay_PushNotification
    {
        public int ID { get; set; }
        public DateTime? Date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Message { get; set; }
    }
}
