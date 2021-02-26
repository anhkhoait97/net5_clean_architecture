using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Card
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long? DSLAMID { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public int? Slot { get; set; }
        public int? Capacity { get; set; }
        public int? Type { get; set; }
        public string CardName { get; set; }
        public byte? Confrm { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string Port { get; set; }
        public int? TypeDevice { get; set; }
        public string PopCard { get; set; }
        public string FirmWare { get; set; }
    }
}
