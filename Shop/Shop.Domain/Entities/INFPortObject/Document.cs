using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class Document
    {
        public long ID { get; set; }
        public string Code { get; set; }
        public string Describe { get; set; }
        public string Description { get; set; }
        public short? Status { get; set; }
        public string Version { get; set; }
        public short? Flag { get; set; }
        public string Compiler { get; set; }
        public int? ServiceIT { get; set; }
        public int? LocationID { get; set; }
        public string Doc_Code { get; set; }
        public DateTime? Active_Date { get; set; }
        public string Number_modify { get; set; }
        public string Type { get; set; }
        public string FormSave { get; set; }
        public string DateSave { get; set; }
        public string Critical_Level { get; set; }
        public string Review_Unit { get; set; }
        public string ApproverBy { get; set; }
        public long? PeopleID { get; set; }
        public string CL_Other { get; set; }
        public string CL_Changed { get; set; }
        public string CL_Incidents { get; set; }
        public string CL_Problem { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string Name { get; set; }
        public string StoragePlace { get; set; }
    }
}

