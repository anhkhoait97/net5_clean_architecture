using Shop.Application.Interfaces.INFPort;
using Shop.Application.Interfaces.Shared;
using Shop.Domain.Entities.INFPort;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Repositories.INFPort
{
    public class PonDeviceRepository : IPonDeviceRepository
    {
        private readonly IRepositoryAsync.INFPort _repository;

        public PonDeviceRepository(IRepositoryAsync.INFPort repository)
        {
            _repository = repository;
        }

        public Task<List<PON_Device>> GetPonDevicesAsync()
        {
            return _repository.ListAsync<PON_Device>();
        }
    }
}
