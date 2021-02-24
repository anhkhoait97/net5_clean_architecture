using Microsoft.EntityFrameworkCore;
using Shop.Application.Common.Interfaces.Repositories;
using Shop.Infrastructure.Persistence.Data.INFPort;
using Shop.Infrastructure.Persistence.Data.INFPortObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Repositories
{
    public class RepositoryAsync
    {

        #region INFPort Db Context
        public class INFPort<T> : IRepositoryAsync.INFPortObject<T> where T : class
        {
            private readonly INFPortContext _dbContext;

            public INFPort(INFPortContext dbContext)
            {
                _dbContext = dbContext;
            }

            public IQueryable<T> Entities => _dbContext.Set<T>();

            public async Task<T> AddAsync(T entity)
            {
                await _dbContext.Set<T>().AddAsync(entity);
                return entity;
            }

            public Task DeleteAsync(T entity)
            {
                _dbContext.Set<T>().Remove(entity);
                return Task.CompletedTask;
            }

            public async Task<List<T>> GetAllAsync()
            {
                return await _dbContext
                    .Set<T>()
                    .ToListAsync();
            }

            public async Task<T> GetByIdAsync(int id)
            {
                return await _dbContext.Set<T>().FindAsync(id);
            }

            public async Task<List<T>> GetPagedReponseAsync(int pageNumber, int pageSize)
            {
                return await _dbContext
                    .Set<T>()
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .AsNoTracking()
                    .ToListAsync();
            }

            public Task UpdateAsync(T entity)
            {
                _dbContext.Entry(entity).CurrentValues.SetValues(entity);
                return Task.CompletedTask;
            }
        }
        #endregion

        #region INFPortObject Db Context
        public class INFPortObject<T> : IRepositoryAsync.INFPort<T> where T : class
        {
            private readonly INFPortObjectContext _dbContext;

            public INFPortObject(INFPortObjectContext dbContext)
            {
                _dbContext = dbContext;
            }

            public IQueryable<T> Entities => _dbContext.Set<T>();

            public async Task<T> AddAsync(T entity)
            {
                await _dbContext.Set<T>().AddAsync(entity);
                return entity;
            }

            public Task DeleteAsync(T entity)
            {
                _dbContext.Set<T>().Remove(entity);
                return Task.CompletedTask;
            }

            public async Task<List<T>> GetAllAsync()
            {
                return await _dbContext
                    .Set<T>()
                    .ToListAsync();
            }

            public async Task<T> GetByIdAsync(int id)
            {
                return await _dbContext.Set<T>().FindAsync(id);
            }

            public async Task<List<T>> GetPagedReponseAsync(int pageNumber, int pageSize)
            {
                return await _dbContext
                    .Set<T>()
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .AsNoTracking()
                    .ToListAsync();
            }

            public Task UpdateAsync(T entity)
            {
                _dbContext.Entry(entity).CurrentValues.SetValues(entity);
                return Task.CompletedTask;
            }
        }
        #endregion

    }
}
