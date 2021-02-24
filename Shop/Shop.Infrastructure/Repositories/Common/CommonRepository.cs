using Microsoft.Extensions.Configuration;
using Shop.Application.Common.Interfaces.Repositories.Common;

namespace Shop.Infrastructure.Repositories.Common
{
    public class CommonRepository : ICommonRepository
    {
        private readonly string _connectionPort;
        private readonly string _connectionPortObject;

        public CommonRepository(IConfiguration configuration)
        {
            _connectionPort = configuration.GetConnectionString("INFPortConnection");
            _connectionPortObject = configuration.GetConnectionString("INFPortObjectConnection");
        }

    }
}
