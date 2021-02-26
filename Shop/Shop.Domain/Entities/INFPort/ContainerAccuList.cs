using System;
namespace Shop.Domain.Entities.INFPort
{
    public class ContainerAccuList
    {
        public long ID { get; set; }
        public string ContainerName { get; set; }
        public string SeriNum { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
