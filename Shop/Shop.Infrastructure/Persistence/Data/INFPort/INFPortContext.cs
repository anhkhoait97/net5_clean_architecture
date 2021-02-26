using Microsoft.EntityFrameworkCore;
using Shop.Application.Interfaces.Shared;
using Shop.Domain.Entities.INFPort;

namespace Shop.Infrastructure.Persistence.Data.INFPort
{
    public class INFPortContext : DbContext, IINFPortContext
    {
        public INFPortContext(DbContextOptions<INFPortContext> options) : base(options)
        {
        }

        public DbSet<PON_Device> PON_Device { get; set; }
    }
}
