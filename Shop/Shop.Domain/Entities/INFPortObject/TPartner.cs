using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TPartner
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int? LocationID { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? OldID { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string FullNameManager { get; set; }
        public string PositionManager { get; set; }
        public string PhoneManager { get; set; }
        public string EmailManager { get; set; }
        public string FullNameKey1 { get; set; }
        public string PositionKey1 { get; set; }
        public string PhoneKey1 { get; set; }
        public string EmailKey1 { get; set; }
        public string FullNameKey2 { get; set; }
        public string PositionKey2 { get; set; }
        public string PhoneKey2 { get; set; }
        public string EmailKey2 { get; set; }
    }
}
