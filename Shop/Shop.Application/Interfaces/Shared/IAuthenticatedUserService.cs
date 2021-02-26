using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Interfaces.Shared
{
    public interface ICurrentUserService
    {
        string UserId { get; }
        public string Username { get; }
    }
}
