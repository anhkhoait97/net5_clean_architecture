using System;
namespace Shop.Domain.Entities.INFPort
{
    public class PointCrossRoad
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long? LocationID { get; set; }
        public long? BranchID { get; set; }
        public string NameOdd { get; set; }
        public string AddressOdd { get; set; }
        public long? StreetOdd { get; set; }
        public long? WardOdd { get; set; }
        public long? DistrictOdd { get; set; }
        public string NameEven { get; set; }
        public string AddressEven { get; set; }
        public long? StreetEven { get; set; }
        public long? WardEven { get; set; }
        public long? DistrictEven { get; set; }
        public int? Status { get; set; }
        public int? IsCableCross { get; set; }
        public string Description { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
