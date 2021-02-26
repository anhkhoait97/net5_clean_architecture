namespace Shop.Domain.Entities.INFPort
{
    public class ReportPop
    {
        public long ID { get; set; }
        public string Location { get; set; }
        public string Branch { get; set; }
        public string BranchName { get; set; }
        public string PopName { get; set; }
        public string AddNumber { get; set; }
        public string Street { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string SumSwitch { get; set; }
        public string SumPortSwitch { get; set; }
        public string SumPortSwitchUser { get; set; }
        public string SumPortSwitchDie { get; set; }
        public string SumPortSwitchFree { get; set; }
        public string SumCard { get; set; }
        public string SumPortCard { get; set; }
        public string SumPortCardUser { get; set; }
        public string SumPortCardDie { get; set; }
        public string SumPortCardFree { get; set; }
        public string SumTD { get; set; }
        public string SumCoreTD { get; set; }
        public string SumCoreTDUser { get; set; }
        public string SumCoreTDDie { get; set; }
        public string SumCoreTDFree { get; set; }
        public string CreateDate { get; set; }
        public int? Region { get; set; }
    }
}
