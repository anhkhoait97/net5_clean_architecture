using System;

namespace Shop.Domain.Entities.INFPort
{
    public class Contract
    {
        public long ContractID { get; set; }
        public string ContractName { get; set; }
        public string CusName { get; set; }
        public string Passport { get; set; }
        public int? CardNumber { get; set; }
        public long ConnectID { get; set; }
        public string LocalType { get; set; }
        public byte? Status { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? Updatedate { get; set; }
        public string UpdateBy { get; set; }
        public long? PopID { get; set; }
        public int? TimeOut { get; set; }
        public byte? Flag { get; set; }
        public string SubTD { get; set; }
        public string Telephone { get; set; }
        public string Handphone { get; set; }
    }
}
