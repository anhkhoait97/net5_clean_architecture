using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities.INFPortObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Interfaces.Shared
{
    public interface IINFPortObjectContext : IDisposable
    {
        public DbSet<Tacit> Tacit { get; set; }
    }
}
