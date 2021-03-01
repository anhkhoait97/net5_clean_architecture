using Shop.Application.Features.TacitWorks.TacitFeature.Commands.SearchTacit;
using Shop.Domain.Entities.INFPortObject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Application.Interfaces.INFPortObject
{
    public interface ITacitRepository
    {
        Task<long> AddTacit(Tacit tacit);

        Task<long> UpdateTacit(Tacit tacit);

        Task<IEnumerable<Tacit>> GetTacitsAsync();
        Task<IEnumerable<SearchTacitRespone>> SearchTacit(SearchTacitCommand request);
    }
}
