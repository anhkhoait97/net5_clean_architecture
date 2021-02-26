using Microsoft.EntityFrameworkCore;
using Shop.Application.Interfaces.Shared;
using Shop.Domain.Entities.INFPortObject;

namespace Shop.Infrastructure.Persistence.Data.INFPortObject
{
    public class INFPortObjectContext : DbContext, IINFPortObjectContext
    {
        public INFPortObjectContext(
            DbContextOptions<INFPortObjectContext> options) : base(options)
        {
        }

        public DbSet<Tacit> Tacit { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
