using System;

namespace Shop.Domain.Entities.INFPort
{
    public class Container
    {
        public long ContainerId { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int? Status { get; set; }
        public string LatLng { get; set; }
        public int? LocationId { get; set; }
        public string Description { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
