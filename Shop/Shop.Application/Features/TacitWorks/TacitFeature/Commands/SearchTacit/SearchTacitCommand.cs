using AutoMapper;
using MediatR;
using Shop.Application.Features.TacitWorks.TacitFeature.Commands.CreateTacit;
using Shop.Application.Interfaces.INFPortObject;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Application.Features.TacitWorks.TacitFeature.Commands.SearchTacit
{
    public class SearchTacitCommand : IRequest<IEnumerable<SearchTacitRespone>>
    {
        public long LocationId { get; set; }
        public string BranchId { get; set; }
        public string Code { get; set; }
        public string InvestId { get; set; }
        public string ManagetUnitId { get; set; }
        public string TypeTacit { get; set; }
    }
    public class SearchTacitRespone
    {
        public long ID { set; get; }
        public int STT { get; set; }
        public int LocationID { set; get; }
        public int BranchID { set; get; }
        public string Name { set; get; }
        public string Code { set; get; }
        public int TypeBuilding { set; get; }
        public string BuildingName { set; get; }
        public long BuildingID { set; get; }
        public string Plans { set; get; }
        public string INFMaintail { set; get; }
        public string Street { set; get; }
        public int Street_District { set; get; }
        public string Street_DistrictName { set; get; }
        public int Street_Ward { set; get; }
        public string Street_WardName { set; get; }
        public string StartName { set; get; }
        public int StartName_District { set; get; }
        public string StartName_DistrictName { set; get; }
        public int StartName_Ward { set; get; }
        public string StartName_WardName { set; get; }
        public string EndName { set; get; }
        public int EndName_District { set; get; }
        public string EndName_DistrictName { set; get; }
        public int EndName_Ward { set; get; }
        public string EndName_WardName { set; get; }
        public string Length { set; get; }
        public string Invest_Costs { set; get; }
        public string Rental_Cost { set; get; }
        public int StartUp_Quarter { set; get; }
        public int StartUp_Year { set; get; }
        public string Start { get; set; }
        public int Finish_Quarter { set; get; }
        public int Finish_Year { set; get; }
        public string Finish { get; set; }
        public int InvestID { set; get; }
        public string InvestName { get; set; }
        public int ManagerUnitID { set; get; }
        public string ManagerUnitName { set; get; }
        public string LinkDesign { set; get; }
        public string Description { set; get; }
        public string CreateDate { set; get; }
        public string CreateBy { set; get; }
        public string UpdateDate { set; get; }
        public string UpdateBy { set; get; }
        public string IsFile { set; get; }
        public int TypeTacit { get; set; }
        public string TypeTacitName { get; set; }
    }
    public class SearchTacitCommandHandler : IRequestHandler<SearchTacitCommand, IEnumerable<SearchTacitRespone>>
    {
        private readonly ITacitRepository _tacitRepository;
        private readonly IMapper _mapper;

        public SearchTacitCommandHandler(ITacitRepository tacitRepository, IMapper mapper)
        {
            _tacitRepository = tacitRepository;
            _mapper = mapper;
        }

        public Task<IEnumerable<SearchTacitRespone>> Handle(SearchTacitCommand request, CancellationToken cancellationToken)
        {
            return _tacitRepository.SearchTacit(request);
        }
    }
}
