using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Shop.Application.Common.Interfaces;
using Shop.Domain.Entities.INFPortObject;
using Shop.Infrastructure.Identity;
using System.Reflection;

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
