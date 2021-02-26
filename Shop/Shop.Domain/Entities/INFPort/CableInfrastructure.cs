using System;
namespace Shop.Domain.Entities.INFPort
{
    public class CableInfrastructure
    {
        public long ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Plans { get; set; }
        public string Asset { get; set; }
        public string Description { get; set; }
        public int? IsCable { get; set; }
        public int? Type { get; set; }
        public int? Capacity { get; set; }
        public int? Length { get; set; }
        public long? StartDeviceID { get; set; }
        public int? StartLength { get; set; }
        public long? EndDeviceID { get; set; }
        public int? EndLength { get; set; }
        public string StartCountCable { get; set; }
        public string EndCountCable { get; set; }
        public string Method { get; set; }
        public string Link { get; set; }
        public int? ManufacturerID { get; set; }
        public int? ManagerUnitID { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public string ProductionYear { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
