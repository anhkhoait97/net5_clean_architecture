using System;

namespace Shop.Domain.Entities.INFPort
{
    public class TypeList
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? Value { get; set; }
        public int? Type { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? NocDepartment { get; set; }
    }
}
