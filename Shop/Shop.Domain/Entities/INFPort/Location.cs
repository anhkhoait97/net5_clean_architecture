namespace Shop.Domain.Entities.INFPort
{
    public class Location
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long? Parent { get; set; }
        public string ParentName { get; set; }
        public string AreaCode { get; set; }
        public int? BranchID { get; set; }
        public int? LocationID { get; set; }
        public int? OutdoorLimit { get; set; }
        public int? Region { get; set; }
        public int? Galvanometer { get; set; }
        public int? Population { get; set; }
    }
}
