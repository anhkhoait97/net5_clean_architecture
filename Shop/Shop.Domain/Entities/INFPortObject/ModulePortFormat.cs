using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class ModulePortFormat
    {
        public long ID { get; set; }
        public int? ParameterNumber { get; set; }
        public int? PortForm { get; set; }
        public int? PortTo { get; set; }
        public long? ModuleID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }

}
