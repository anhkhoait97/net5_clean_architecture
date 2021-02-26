namespace Shop.Domain.Entities.INFPort
{
    public class ErrorImport
    {
        public int ID { get; set; }
        public string PopName { get; set; }
        public string ContractName { get; set; }
        public string DSLamInside { get; set; }
        public string SlotInside { get; set; }
        public string PortInside { get; set; }
        public string DSLamExcel { get; set; }
        public string SlotExcel { get; set; }
        public string PortExcel { get; set; }
        public string Description { get; set; }
        public int? BranchID { get; set; }
    }
}
