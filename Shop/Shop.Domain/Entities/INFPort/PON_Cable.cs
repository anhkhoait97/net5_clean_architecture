using System;

namespace Shop.Domain.Entities.INFPort
{
    public class PON_Cable
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? Capacity { get; set; }
        public string Description { get; set; }
        public int? Length { get; set; }
        public int? StartLength { get; set; }
        public int? EndLength { get; set; }
        public long StartdeviceID { get; set; }
        public long EndDeviceID { get; set; }
        public string Type { get; set; }
        public int? TypeDevice { get; set; }
        public string Plans { get; set; }
        public string Equipment { get; set; }
        public int? ManufactureID { get; set; }
        public int? ManagerUnitID { get; set; }
        public string ProductName { get; set; }
        public string Method { get; set; }
        public int? LocationID { get; set; }
        public DateTime? ActiveDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? IsDevice { get; set; }
        public string Pop_Cable { get; set; }
        public long? CableID { get; set; }
        public int? TypeCableID { get; set; }
        public int? CableLineID { get; set; }
        public int? StartTubeLoose { get; set; }
        public int? EndTubeLoose { get; set; }
    }
}
