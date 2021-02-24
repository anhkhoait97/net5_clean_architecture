using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Common.Interfaces.Repositories.Common
{
    public interface ICommonRepository
    {
        Task<bool> IsDistricWard(long locationId, int disctrictId, int wardId);
        Task<bool> IsTList(int id, int type);
        Task<bool> IsTArray(int valueId, int type);
        Task<bool> IsBuildingInside(int locationId, long id, string name);
        Task<bool> IsYearStartFinish(int year);
        Task<bool> IsPlanInside(string plan);
        Task<bool> CheckFirstAndLastDeviceTube(string firstDevice, string lastDevice);
        Task<bool> IsExistDevice(int type, string device);
        Task<bool> IsExistsTacitInLocationAndBranch(long locationId, string branchId, long tacitId);
        Task<bool> IsExistsStartConnectPoint(long locationId, string branchId, long connectPointId, int startConnect);
        Task<bool> IsSectionInBellow(long sectionId, long bellowId, int type);
        Task<bool> IsPiInDevice(string deviceName, long id, int Type);
        Task<bool> IsExistsPointConnect(long id, string pointConnectName, int type);
        Task<bool> IsExistsTpartner(string partnerId, long locationId);
        Task<bool> IsExistsCableInLocationAndBranch(long locationId, string branchId, long tacitId);
        Task<bool> IsExistsUnitPrice(long locationId, long branchId, long id);

    }
}
