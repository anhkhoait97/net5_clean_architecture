using System;
namespace Shop.Domain.Entities.INFPort
{
    public class ContainerCatalog
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string ParentKey { get; set; }
        public int? Status { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
