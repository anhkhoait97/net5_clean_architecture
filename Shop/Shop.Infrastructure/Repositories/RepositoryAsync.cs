using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shop.Application.Interfaces.Shared;
using Shop.Domain.Common;
using Shop.Infrastructure.Persistence.Data.INFPort;
using Shop.Infrastructure.Persistence.Data.INFPortObject;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Repositories
{
    public class RepositoryAsync
    {
        #region INFPort Db Context

        public class INFPort : IRepositoryAsync.INFPort
        {
            private readonly INFPortContext _dbContext;
            private readonly IConfiguration _configuration;

            public INFPort(INFPortContext dbContext, IConfiguration configuration)
            {
                _dbContext = dbContext;
                _configuration = configuration;
            }

            public string StrConnect => _configuration.GetConnectionString("INFPortConnection");

            public T GetById<T>(long id) where T : BaseEntity
            {
                return _dbContext.Set<T>().SingleOrDefault(e => e.ID == id);
            }

            public Task<T> GetByIdAsync<T>(long id) where T : BaseEntity
            {
                return _dbContext.Set<T>().SingleOrDefaultAsync(e => e.ID == id);
            }

            public Task<List<T>> ListAsync<T>() where T : BaseEntity
            {
                return _dbContext.Set<T>().ToListAsync();
            }

            public async Task<T> AddAsync<T>(T entity) where T : BaseEntity
            {
                await _dbContext.Set<T>().AddAsync(entity);
                await _dbContext.SaveChangesAsync();

                return entity;
            }

            public Task UpdateAsync<T>(T entity) where T : BaseEntity
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
                return _dbContext.SaveChangesAsync();
            }

            public Task DeleteAsync<T>(T entity) where T : BaseEntity
            {
                _dbContext.Set<T>().Remove(entity);
                return _dbContext.SaveChangesAsync();
            }
        }

        #endregion INFPort Db Context

        #region INFPortObject Db Context

        public class INFPortObject : IRepositoryAsync.INFPortObject
        {
            private readonly INFPortObjectContext _dbContext;
            private readonly IConfiguration _configuration;

            public INFPortObject(INFPortObjectContext dbContext, IConfiguration configuration)
            {
                _dbContext = dbContext;
                _configuration = configuration;
            }

            public string StrConnect => _configuration.GetConnectionString("INFPortObjectConnection");

            public T GetById<T>(long id) where T : BaseEntity
            {
                return _dbContext.Set<T>().SingleOrDefault(e => e.ID == id);
            }

            public Task<T> GetByIdAsync<T>(long id) where T : BaseEntity
            {
                return _dbContext.Set<T>().SingleOrDefaultAsync(e => e.ID == id);
            }

            public Task<List<T>> ListAsync<T>() where T : BaseEntity
            {
                return _dbContext.Set<T>().ToListAsync();
            }

            public async Task<T> AddAsync<T>(T entity) where T : BaseEntity
            {
                await _dbContext.Set<T>().AddAsync(entity);
                await _dbContext.SaveChangesAsync();

                return entity;
            }

            public Task UpdateAsync<T>(T entity) where T : BaseEntity
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
                return _dbContext.SaveChangesAsync();
            }

            public Task DeleteAsync<T>(T entity) where T : BaseEntity
            {
                _dbContext.Set<T>().Remove(entity);
                return _dbContext.SaveChangesAsync();
            }
        }

        #endregion INFPortObject Db Context
    }
}
