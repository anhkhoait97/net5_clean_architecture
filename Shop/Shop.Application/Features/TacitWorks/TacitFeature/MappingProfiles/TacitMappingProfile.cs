using AutoMapper;
using Shop.Application.Features.TacitWorks.TacitFeature.Commands.CreateTacit;
using Shop.Application.Features.TacitWorks.TacitFeature.Queries.GetTacits;
using Shop.Domain.Entities.INFPortObject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Application.Features.TacitWorks.TacitFeature.MappingProfiles
{
    public class TacitMappingProfile : Profile
    {
        public TacitMappingProfile()
        {
            CreateMap<CreateTacitCommand, Tacit>();
            CreateMap<Tacit, TacitVm>();
            CreateMap<Task<IEnumerable<Tacit>>, Task<IEnumerable<TacitVm>>>();
        }
    }
}
