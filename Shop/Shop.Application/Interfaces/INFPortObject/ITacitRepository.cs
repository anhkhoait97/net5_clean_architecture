using Shop.Domain.Entities.INFPortObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Interfaces.INFPortObject
{
    public interface ITacitRepository
    {
        Task<long> AddTacit(Tacit tacit);
        Task<long> UpdateTacit(Tacit tacit);
        Task<IEnumerable<Tacit>> GetTacitsAsync();
    }
}
