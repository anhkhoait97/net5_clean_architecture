using Shop.Domain.Entities.INFPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Interfaces.INFPort
{
    public interface IPonDeviceRepository
    {
        Task<List<PON_Device>> GetPonDevicesAsync();
    }
}
