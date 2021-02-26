using System;
namespace Shop.Domain.Entities.INFPort
{
    public class CRCoreCable
    {
        public long ID { get; set; }
        public int? Core { get; set; }
        public int? Status { get; set; }
        public int Attenuation { get; set; }
        public int? PurposeID { get; set; }
        public long? CableID { get; set; }
        public long? StartPortID { get; set; }
        public long? EndPortID { get; set; }
        public long? StartCoreID { get; set; }
        public long? EndCoreID { get; set; }
        public string Type { get; set; }
        public int? ManagerUnitID { get; set; }
        public int? UsedUnitID { get; set; }
        public string Layer { get; set; }
        public int RouteID { get; set; }
        public string RouteName { get; set; }
        public byte RouteType { get; set; }
        public int OrderNumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string ChannelID { get; set; }
    }
}
