using AutoMapper;
using Shop.Application.Features.TacitWorks.Tacit.Commands.CreateTacit;
using Shop.Application.Features.TacitWorks.Tacit.Queries.GetTacits;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Application.Features.TacitWorks.Tacit.MappingProfiles
{
    public class TacitMappingProfile : Profile
    {
        public TacitMappingProfile()
        {
            CreateMap<CreateTacitCommand, Domain.Entities.INFPortObject.Tacit>();
            CreateMap<Domain.Entities.INFPortObject.Tacit, TacitVm>();
            CreateMap<Task<IEnumerable<Domain.Entities.INFPortObject.Tacit>>, Task<IEnumerable<TacitVm>>>();

        }
    }
}
