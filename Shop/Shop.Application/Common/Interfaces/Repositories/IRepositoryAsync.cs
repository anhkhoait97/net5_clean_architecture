using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Common.Interfaces.Repositories
{
    public interface IRepositoryAsync
    {
        public interface INFPort<T> where T : class
        {
            IQueryable<T> Entities { get; }

            Task<T> GetByIdAsync(int id);

            Task<List<T>> GetAllAsync();

            Task<List<T>> GetPagedReponseAsync(int pageNumber, int pageSize);

            Task<T> AddAsync(T entity);

            Task UpdateAsync(T entity);

            Task DeleteAsync(T entity);
        }

        public interface INFPortObject<T> where T : class
        {
            IQueryable<T> Entities { get; }

            Task<T> GetByIdAsync(int id);

            Task<List<T>> GetAllAsync();

            Task<List<T>> GetPagedReponseAsync(int pageNumber, int pageSize);

            Task<T> AddAsync(T entity);

            Task UpdateAsync(T entity);

            Task DeleteAsync(T entity);
        }
    }
}
