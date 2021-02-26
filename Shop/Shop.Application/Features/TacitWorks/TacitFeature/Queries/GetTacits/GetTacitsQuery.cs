using AutoMapper;
using MediatR;
using Shop.Application.Interfaces.INFPortObject;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Application.Features.TacitWorks.TacitFeature.Queries.GetTacits
{
    public class GetTacitsQuery : IRequest<IEnumerable<TacitVm>>
    {
    }

    public class GetTacitsQueryHandler : IRequestHandler<GetTacitsQuery, IEnumerable<TacitVm>>
    {
        private readonly ITacitRepository _tacitRepository;
        private readonly IMapper _mapper;

        public GetTacitsQueryHandler(ITacitRepository tacitRepository, IMapper mapper)
        {
            _tacitRepository = tacitRepository;
            _mapper = mapper;
        }

        public Task<IEnumerable<TacitVm>> Handle(GetTacitsQuery request, CancellationToken cancellationToken)
        {
            var listTacit = _tacitRepository.GetTacitsAsync();
            var listTacitVm = _mapper.Map<Task<IEnumerable<TacitVm>>>(listTacit);
            return listTacitVm;
        }
    }
}
