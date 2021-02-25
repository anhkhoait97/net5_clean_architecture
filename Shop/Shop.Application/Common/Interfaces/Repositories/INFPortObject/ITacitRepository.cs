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
        Task<long> AddTacit(Tacit tacit);
        Task<IEnumerable<Tacit>> GetTacitsAsync();
    }
}
