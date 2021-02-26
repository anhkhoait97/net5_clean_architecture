namespace Shop.Domain.Entities.INFPort
{
    public class RuleGroupUpdateStatusPort
    {
        public long ID { get; set; }
        public long? GroupID { get; set; }
        public int? OldStatus { get; set; }
        public int? NewStatus { get; set; }
    }
}
