using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class RTDiagramChannel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public int? TypeINFID { get; set; }
        public int? LevelID { get; set; }
        public string Path { get; set; }
        public int? UnitManagementID { get; set; }
        public int? UnitUserID { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? FunctionID { get; set; }
        public int? TypeDiagram { get; set; }
        public int? TypeDiagramDetail { get; set; }
        public long? PopID { get; set; }
        public long? DeviceID { get; set; }
        public int? TypeDevice { get; set; }
    }
}

