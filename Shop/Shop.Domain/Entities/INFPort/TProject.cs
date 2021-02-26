using System;

namespace Shop.Domain.Entities.INFPort
{
    public class TProject
    {
        public long ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string StartDevice { get; set; }
        public string EndDevice { get; set; }
        public string Length { get; set; }
        public int? Customer { get; set; }
        public int? Port { get; set; }
        public string Investment_Costs { get; set; }
        public string Rental_Costs { get; set; }
        public int? StartUp_Quater { get; set; }
        public int? StartUp_Year { get; set; }
        public int? Finish_Quater { get; set; }
        public int? Finish_Year { get; set; }
        public int? InvestorsID { get; set; }
        public string Rivals { get; set; }
        public string Description { get; set; }
        public int? LocationID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
