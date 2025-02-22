using System;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Application.Interfaces.Shared
{
    public interface IUnitOfWork
    {
        public interface INFPort : IDisposable
        {
            Task<int> Commit(CancellationToken cancellationToken);

            Task Rollback();
        }

        public interface INFPortObject : IDisposable
        {
            Task<int> Commit(CancellationToken cancellationToken);

            Task Rollback();
        }
    }
}
