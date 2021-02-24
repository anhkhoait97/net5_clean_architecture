using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TManuaBillding
    {
        public long ID { get; set; }
        public string CableName { get; set; }
        public string TacitCode { get; set; }
        public string ODCCableType { get; set; }
        public string NameTacit { get; set; }
        public string NameObject { get; set; }
        public string EndName { get; set; }
        public string TypeCable { get; set; }
        public string Capacity { get; set; }
        public string Formality { get; set; }
        public string CableLength { get; set; }
        public string Price { get; set; }
        public long? ContractID { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }

}
