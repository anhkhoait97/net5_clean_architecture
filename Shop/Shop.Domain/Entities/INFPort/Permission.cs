using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Permission
    {
        public long ID { get; set; }
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string Funtion { get; set; }
        public string Department { get; set; }
        public string Region { get; set; }
        public int? StatusRequest { get; set; }
        public string ContentRequest { get; set; }
        public int? StatusProcess { get; set; }
        public string ContentProcess { get; set; }
        public string RequestBy { get; set; }
        public string ProcessBy { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? ProcessDate { get; set; }
    }
}
