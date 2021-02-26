namespace Shop.Domain.Entities.INFPortObject
{
    public class TypeMail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Condition { get; set; }
        public int? TypeCondition { get; set; }
        public int? RuleTime { get; set; }
        public int? ValuesTime { get; set; }
        public int? Approved { get; set; }
        public string TitleMailFirst { get; set; }
        public string TitleMailEnd { get; set; }
        public string BodyFirst { get; set; }
        public string BodyFTS { get; set; }
        public string BodyFTN { get; set; }
        public string Description { get; set; }
    }
}
