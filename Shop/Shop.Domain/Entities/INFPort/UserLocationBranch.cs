namespace Shop.Domain.Entities.INFPort
{
    public class UserLocationBranch
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public long? LocationID { get; set; }
        public long? BranchID { get; set; }
    }
}
