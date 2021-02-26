using System;

namespace Shop.Domain.Entities.INFPort
{
    public class ContainerMailList
    {
        public long ID { get; set; }
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? Role { get; set; }
        public long? ContainerId { get; set; }
        public string ContainerName { get; set; }
        public string Description { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
