using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Application.Features.TacitWorks.TacitFeature.Commands.SearchTacit
{
    public class SearchTacitCommand : IRequest
    {
        
    }
    public class SearchTacitCommandHandler : IRequestHandler<SearchTacitCommand>
    {
        public Task<Unit> Handle(SearchTacitCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
