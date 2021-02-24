using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities.INFPortObject;

namespace Shop.Application.Common.Interfaces
{
    public interface IINFPortObjectContext
    {
        public DbSet<Tacit> Tacits{ get; set; }
    }
}
