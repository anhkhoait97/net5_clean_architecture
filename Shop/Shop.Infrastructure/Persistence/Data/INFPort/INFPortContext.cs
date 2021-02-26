using Microsoft.EntityFrameworkCore;
using Shop.Application.Interfaces.Shared;
using Shop.Domain.Entities.INFPort;
using Shop.Domain.Entities.INFPortObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
