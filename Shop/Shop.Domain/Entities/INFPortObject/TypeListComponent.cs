using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TypeListComponent
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? TypeListID { get; set; }
        public string Desrciption { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? Flag { get; set; }
    }

}
