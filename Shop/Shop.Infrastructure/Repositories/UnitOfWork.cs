using Shop.Application.Common.Interfaces.Repositories;
using Shop.Application.Common.Interfaces.Shared;
using Shop.Infrastructure.Persistence.Data.INFPort;
using Shop.Infrastructure.Persistence.Data.INFPortObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Repositories
{
    public static class UnitOfWork
    {
        #region INFPort
        public class INFPort : IUnitOfWork.INFPort
        {
 
            private readonly INFPortContext _dbContext;
            private bool disposed;

            public INFPort(INFPortContext dbContext)
            {
                _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            }

            public async Task<int> Commit(CancellationToken cancellationToken)
            {
                return await _dbContext.SaveChangesAsync(cancellationToken);
            }

            public Task Rollback()
            {
                //todo
                return Task.CompletedTask;
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!disposed)
                {
                    if (disposing)
                    {
                        //dispose managed resources
                        _dbContext.Dispose();
                    }
                }
                //dispose unmanaged resources
                disposed = true;
            }
        }


        #endregion
        #region INFPortObject
        public class INFPortObject : IUnitOfWork.INFPortObject
        {
            private readonly INFPortObjectContext _dbContext;
            private bool disposed;

            public INFPortObject(INFPortObjectContext dbContext)
            {
                _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            }

            public async Task<int> Commit(CancellationToken cancellationToken)
            {
                return await _dbContext.SaveChangesAsync(cancellationToken);
            }

            public Task Rollback()
            {
                //todo
                return Task.CompletedTask;
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!disposed)
                {
                    if (disposing)
                    {
                        //dispose managed resources
                        _dbContext.Dispose();
                    }
                }
                //dispose unmanaged resources
                disposed = true;
            }
        }
        #endregion

    }
}
