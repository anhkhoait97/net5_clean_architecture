using Shop.Domain.Entities.INFPort;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Application.Interfaces.INFPort
{
    public interface IPonDeviceRepository
    {
        Task<List<PON_Device>> GetPonDevicesAsync();
    }
}
