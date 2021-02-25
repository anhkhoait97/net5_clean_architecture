using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities.INFPortObject;
using System;

namespace Shop.Application.Common.Interfaces
{
    public interface IINFPortObjectContext : IDisposable
    {
        public DbSet<Tacit> Tacit{ get; set; }
    }
}
