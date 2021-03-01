using AutoMapper;
using MediatR;
using Shop.Application.Interfaces.INFPortObject;
using Shop.Domain.Entities.INFPortObject;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Application.Features.TacitWorks.TacitFeature.Commands.UpdateTacit
{
    public class UpdateTacitCommand : IRequest<long>
    {
        public int LocationID { set; get; }
        public int BranchID { set; get; }
        public string Name { set; get; }
        public string Code { set; get; }
        public int TypeBuilding { set; get; }
        public string BuildingName { set; get; }
        public long BuildingID { set; get; }
        public string Plans { set; get; }
        public string INFMaintain { set; get; }
        public string Street { set; get; }
        public int Street_Dis { set; get; }
        public int Street_War { set; get; }
        public string StartName { set; get; }
        public int StartName_Dis { set; get; }
        public int StartName_War { set; get; }
        public string EndName { set; get; }
        public int EndName_Dis { set; get; }
        public int EndName_War { set; get; }
        public string Length { set; get; }
        public string Inves_Costs { set; get; }
        public string Rental_Cost { set; get; }
        public int StartUp_Quarter { set; get; }
        public int StartUp_Year { set; get; }
        public int Finish_Quarter { set; get; }
        public int Finish_Year { set; get; }
        public int InvesID { set; get; }
        public int ManagerUnitID { set; get; }
        public string LinkDesign { set; get; }
        public string Description { set; get; }
        public DateTime CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime UpdateDate { set; get; }
        public string UpdateBy { set; get; }
        public string IsFile { set; get; }
        public string FileName { set; get; }
        public string LinkFile { set; get; }
        public string FileNameHistory { get; set; }
        public int TypeTacit { get; set; }
        public int Count { get; set; }
        public string[] ListFileName { get; set; }
        public string[] ListFiles { get; set; }
    }

    public class CreateTacitCommandHandler : IRequestHandler<UpdateTacitCommand, long>
    {
        private readonly ITacitRepository _tacitRepository;
        private readonly IMapper _mapper;

        public CreateTacitCommandHandler(ITacitRepository tacitRepository, IMapper mapper)
        {
            _tacitRepository = tacitRepository;
            _mapper = mapper;
        }

        public Task<long> Handle(UpdateTacitCommand request, CancellationToken cancellationToken)
        {
            var tacit = _mapper.Map<UpdateTacitCommand, Tacit>(request);
            return _tacitRepository.UpdateTacit(tacit);
        }
    }
}
