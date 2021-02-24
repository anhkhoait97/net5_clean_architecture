using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Application.Common.Interfaces.Repositories
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
