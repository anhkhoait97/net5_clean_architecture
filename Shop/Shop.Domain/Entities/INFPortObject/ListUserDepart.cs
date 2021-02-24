using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class ListUserDepart
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int? DepartID { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? OriginalDepartID { get; set; }
    }
}
