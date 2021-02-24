using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Common.Interfaces.Shared
{
    public interface IAuthenticatedUserService
    {
        string UserId { get; }
        public string Username { get; }
    }
}
