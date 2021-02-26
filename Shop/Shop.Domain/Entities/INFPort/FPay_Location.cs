using System;
namespace Shop.Domain.Entities.INFPort
{
    public class FPay_Location
    {
        public int ID { get; set; }
        public int? ObjID { get; set; }
        public int? StaffID { get; set; }
        public double? ObjLng { get; set; }
        public double? ObjLat { get; set; }
        public double? TDLng { get; set; }
        public double? TDLat { get; set; }
        public double? Distance { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string TDName { get; set; }
        public string LatLng { get; set; }
        public string TDLatLng { get; set; }
        public int? Accuracy { get; set; }
        public string UserAccept { get; set; }
        public DateTime? AcceptDate { get; set; }
    }
}
