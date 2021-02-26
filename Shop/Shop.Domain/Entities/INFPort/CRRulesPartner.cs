namespace Shop.Domain.Entities.INFPort
{
    public class CRRulesPartner
    {
        public long ID { get; set; }
        public string UserID { get; set; }
        public long? RouteCableID { get; set; }
        public bool? IsInsert { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsUpdate { get; set; }
        public bool? IsView { get; set; }
    }
}
