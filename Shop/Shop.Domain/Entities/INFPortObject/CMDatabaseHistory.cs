using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class CMDatabaseHistory
    {
        public long ID { get; set; }
        public long? CMDatabaseID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Describe { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public string Version { get; set; }
        public short? Flag { get; set; }
        public long? PeopleID { get; set; }
        public int? ServiceIT { get; set; }
        public int? LocationID { get; set; }
        public string Functions { get; set; }
        public long? DeviceID { get; set; }
        public string CL_Changed { get; set; }
        public string CL_Incidents { get; set; }
        public string CL_Problem { get; set; }
        public string IP { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string RelationshipObject { get; set; }
    }
}

