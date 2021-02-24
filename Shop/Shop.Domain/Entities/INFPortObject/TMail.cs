using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TMail
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public long? BranchID { get; set; }
        public long? LocationID { get; set; }
        public long? Type { get; set; }
        public long? TypeMail { get; set; }
        public string Note { get; set; }
        public int? PartnerID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }

}
