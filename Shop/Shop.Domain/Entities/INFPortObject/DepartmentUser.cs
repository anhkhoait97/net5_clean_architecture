using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class DepartmentUser
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int? DepartmentID { get; set; }
        public short? IsDepart { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}

