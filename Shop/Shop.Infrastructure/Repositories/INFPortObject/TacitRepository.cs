using Microsoft.EntityFrameworkCore;
using Shop.Application.Common.Interfaces.Repositories;
using Shop.Application.Common.Interfaces.Repositories.INFPortObject;
using Shop.Domain.Entities.INFPortObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Repositories.INFPortObject
{
    public class TacitRepository : ITacitRepository
    {
        private readonly IRepositoryAsync.INFPortObject<Tacit> _repository;
       
        public TacitRepository(IRepositoryAsync.INFPortObject<Tacit> repository)
        {
            _repository = repository;
        }
        public IQueryable<Tacit> Tacits => _repository.Entities;

        public async Task DeleteAsync(Tacit tacit)
        {
            await _repository.DeleteAsync(tacit);
        }

        public async Task<Tacit> GetByIdAsync(int tacitId)
        {
            return await _repository.Entities.Where(p => p.ID == tacitId).FirstOrDefaultAsync();
        }

        public async Task<List<Tacit>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<long> InsertAsync(Tacit tacit)
        {
            await _repository.AddAsync(tacit);
            return tacit.ID;
        }

        public async Task UpdateAsync(Tacit tacit)
        {
            await _repository.UpdateAsync(tacit);
        }
    }
}
