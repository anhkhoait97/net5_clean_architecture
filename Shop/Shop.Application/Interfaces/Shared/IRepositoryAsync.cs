using Shop.Domain.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Application.Interfaces.Shared
{
    public interface IRepositoryAsync
    {
        public interface INFPort
        {
            string StrConnect { get; }

            Task<T> GetByIdAsync<T>(long id) where T : BaseEntity;

            Task<List<T>> ListAsync<T>() where T : BaseEntity;

            Task<T> AddAsync<T>(T entity) where T : BaseEntity;

            Task UpdateAsync<T>(T entity) where T : BaseEntity;

            Task DeleteAsync<T>(T entity) where T : BaseEntity;
        }

        public interface INFPortObject
        {
            string StrConnect { get; }

            Task<T> GetByIdAsync<T>(long id) where T : BaseEntity;

            Task<List<T>> ListAsync<T>() where T : BaseEntity;

            Task<T> AddAsync<T>(T entity) where T : BaseEntity;

            Task UpdateAsync<T>(T entity) where T : BaseEntity;

            Task DeleteAsync<T>(T entity) where T : BaseEntity;
        }
    }
}
