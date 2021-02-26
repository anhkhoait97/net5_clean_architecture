using System;
namespace Shop.Domain.Entities.INFPort
{
    public class HistoryBuilding
    {
        public long ID { get; set; }
        public long? LocationID { get; set; }
        public string Name { get; set; }
        public int? TypeDevice { get; set; }
        public int? TypeBuilding { get; set; }
        public string BuildingName { get; set; }
        public int? Action { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
