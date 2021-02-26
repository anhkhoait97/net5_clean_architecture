namespace Shop.Domain.Entities.INFPort
{
    public class TV_TypeListDetail
    {
        public int ID { get; set; }
        public int? TypeListID { get; set; }
        public string Port { get; set; }
        public int? Type { get; set; }
        public double? Depreciation { get; set; }
        public string Unit { get; set; }
    }
}
