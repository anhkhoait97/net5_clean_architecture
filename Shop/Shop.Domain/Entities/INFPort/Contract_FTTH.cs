using System;
namespace Shop.Domain.Entities.INFPort
{
    public class Contract_FTTH
    {
        public long ID { get; set; }
        public string ContractName { get; set; }
        public string CusName { get; set; }
        public int? CardNumber { get; set; }
        public string CMND { get; set; }
        public string LocalType { get; set; }
        public byte? Status { get; set; }
        public int? Type { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? Updatedate { get; set; }
        public string UpdateBy { get; set; }
        public long? TDID { get; set; }
        public string Telephone { get; set; }
        public string Handphone { get; set; }
    }
}
