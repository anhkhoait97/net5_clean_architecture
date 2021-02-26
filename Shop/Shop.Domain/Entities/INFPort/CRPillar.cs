using System;

namespace Shop.Domain.Entities.INFPort
{
    public class CRPillar
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? ReserveA { get; set; }
        public int? ReserveB { get; set; }
        public string Equipment { get; set; }
        public int? ManagerUnitID { get; set; }
        public int? Status { get; set; }
        public string Description { get; set; }
        public int? RouteCableID { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Type { get; set; }
    }
}
