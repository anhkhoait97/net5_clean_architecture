using Shop.Domain.Entities.INFPortObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Common.Interfaces.Repositories.INFPortObject
{
    public interface ITacitRepository
    {
        IQueryable<Tacit> Tacits { get; }

        Task<List<Tacit>> GetListAsync();

        Task<Tacit> GetByIdAsync(int tacitId);

        Task<long> InsertAsync(Tacit tacit);

        Task UpdateAsync(Tacit tacit);

        Task DeleteAsync(Tacit tacit);
    }
}
