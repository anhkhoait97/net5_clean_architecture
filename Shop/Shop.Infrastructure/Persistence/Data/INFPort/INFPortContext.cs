using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Persistence.Data.INFPort
{
    public class INFPortContext : DbContext
    {
        public INFPortContext(DbContextOptions options) : base(options)
        {

        }
    }
}
