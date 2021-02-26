using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities.INFPortObject;
using System;

namespace Shop.Application.Interfaces.Shared
{
    public interface IINFPortObjectContext : IDisposable
    {
        public DbSet<Tacit> Tacit { get; set; }
    }
}
