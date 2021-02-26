namespace Shop.Domain.Entities.INFPort
{
    public class Report_PopWarning
    {
        public long ID { get; set; }
        public string PopName { get; set; }
        public string LocationID { get; set; }
        public string BranchID { get; set; }
        public string BranchName { get; set; }
        public string SumPort { get; set; }
        public string SumPortUse { get; set; }
        public string Percents { get; set; }
        public string TypeBuilding { get; set; }
        public string BuildingName { get; set; }
        public string WarningName { get; set; }
        public string WarningID { get; set; }
        public string TypeDevice { get; set; }
        public int? TypeReport { get; set; }
        public string CreateDate { get; set; }
        public string DateData { get; set; }
    }
}
