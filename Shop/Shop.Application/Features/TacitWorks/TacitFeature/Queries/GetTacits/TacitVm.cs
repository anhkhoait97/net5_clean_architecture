using System;

namespace Shop.Application.Features.TacitWorks.TacitFeature.Queries.GetTacits
{
    public class TacitVm
    {
        public long ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? LocationID { get; set; }
        public int? BranchID { get; set; }
        public string Plans { get; set; }
        public string INFMaintail { get; set; }
        public int? TypeBuilding { get; set; }
        public long? BuildingID { get; set; }
        public string BuildingName { get; set; }
        public string Street { get; set; }
        public int? Street_District { get; set; }
        public int? Street_Ward { get; set; }
        public string StartName { get; set; }
        public int? StartName_District { get; set; }
        public int? StartName_Ward { get; set; }
        public string EndName { get; set; }
        public int? EndName_District { get; set; }
        public int? EndName_Ward { get; set; }
        public string Length { get; set; }
        public string Invest_Costs { get; set; }
        public string Rental_Cost { get; set; }
        public int? StartUp_Quarter { get; set; }
        public int? StartUp_Year { get; set; }
        public int? Finish_Quarter { get; set; }
        public int? Finish_Year { get; set; }
        public int? InvestID { get; set; }
        public int? ManagerUnitID { get; set; }
        public string LinkDesign { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string IsFile { get; set; }
        public int? Flag { get; set; }
        public int? TypeTacit { get; set; }
    }
}
