using System;

namespace Shop.Domain.Entities.INFPort
{
    public class TV_Cable
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public int? TypeStart { get; set; }
        public long? StartDeviceID { get; set; }
        public int? TypeEnd { get; set; }
        public long? EndDeviceID { get; set; }
        public int? Capacity { get; set; }
        public int? Length { get; set; }
        public int? StartLength { get; set; }
        public int? EndLength { get; set; }
        public long? NodeID { get; set; }
        public int? LocationID { get; set; }
        public string Method { get; set; }
        public string Depriciation { get; set; }
        public string Description { get; set; }
        public DateTime? DateUse { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? TypeDevice { get; set; }
        public int? TypeFiber { get; set; }
    }
}
