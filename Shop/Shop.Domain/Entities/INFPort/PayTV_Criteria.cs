using System;

namespace Shop.Domain.Entities.INFPort
{
    public class PayTV_Criteria
    {
        public int ID { get; set; }
        public int? LocationID { get; set; }
        public int? DistrictID { get; set; }
        public int? Criteria { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
