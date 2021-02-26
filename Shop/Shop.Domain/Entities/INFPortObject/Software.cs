using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class Software
    {
        public long ID { get; set; }
        public string Code { get; set; }
        public string Describe { get; set; }
        public string Description { get; set; }
        public string Producer { get; set; }
        public string Support { get; set; }
        public string Version { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? Status { get; set; }
        public int? Flag { get; set; }
        public long? PeopleID { get; set; }
        public int? ServiceIT { get; set; }
        public int? LocationID { get; set; }
        public long? DeviceID { get; set; }
        public string CL_Changed { get; set; }
        public string CL_Incidents { get; set; }
        public string CL_Problem { get; set; }
        public int? Priority { get; set; }
        public string PatchNumber { get; set; }
        public int? LicenseType { get; set; }
        public string LicensesAvailable { get; set; }
        public string ConfiBasicNumber { get; set; }
        public string BuildType { get; set; }
        public string ContractID { get; set; }
        public string BuildNumber { get; set; }
        public string ServicePack { get; set; }
        public long? DocumentID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Name { get; set; }
        public string VersionCI { get; set; }
    }
}
