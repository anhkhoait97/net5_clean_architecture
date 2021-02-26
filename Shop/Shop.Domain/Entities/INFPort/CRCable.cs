using System;
namespace Shop.Domain.Entities.INFPort
{
    public class CRCable
    {
        public long ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Asset { get; set; }
        public int? Capacity { get; set; }
        public string Description { get; set; }
        public int? Length { get; set; }
        public int? StartLength { get; set; }
        public int? EndLength { get; set; }
        public long StartdeviceID { get; set; }
        public long EndDeviceID { get; set; }
        public string Type { get; set; }
        public string Link { get; set; }
        public int? ManufactureID { get; set; }
        public int? ManagerUnitID { get; set; }
        public string Method { get; set; }
        public int? LocationID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
