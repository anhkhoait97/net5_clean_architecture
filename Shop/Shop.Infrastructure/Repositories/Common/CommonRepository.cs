using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Shop.Application.Common.Interfaces.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

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

        public async Task<bool> CheckFirstAndLastDeviceTube(string firstDevice, string lastDevice)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                FirstDeviceName = firstDevice,
                LastDeviceName = lastDevice
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_spCheck_FisrtAndLastDeviceTube", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public async Task<bool> IsBuildingInside(int locationId, long id, string name)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                location = locationId,
                ID = id,
                Name = name
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckBuildingInSide", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public async Task<bool> IsDistrictWard(long locationId, int disctrictId, int wardId)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                LocationID = locationId,
                Street_District = disctrictId,
                Street_Ward = wardId
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckExistsDistricWard", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public async Task<bool> IsExistsDevice(int type, string device)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                Type = type,
                Device = device
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckExistsDevice", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public async Task<bool> IsExistsCableInLocationAndBranch(long locationId, string branchId, long cableId)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                LocationID = locationId,
                BranchID = branchId,
                CableID = cableId
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckExistsDevice", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public async Task<bool> IsExistsPointConnect(long id, string pointConnectName, int type)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                ID = id,
                PointConnectName = pointConnectName,
                Type = type
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckPointConnect", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public async Task<bool> IsExistsStartConnectPoint(long locationId, string branchId, long connectPointId, int startConnect)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                LocationID = locationId,
                BranchID = branchId,
                ConnectPointID = connectPointId,
                StartConnect = startConnect,
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckStartConnectPoint", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public async Task<bool> IsExistsTacitInLocationAndBranch(long locationId, string branchId, long tacitId)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                LocationID = locationId,
                BranchID = branchId,
                TacitID = tacitId,
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckTacitExistsLocationAndBranch", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public async Task<bool> IsExistsTpartner(string partnerId, long locationId)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                LocationID = locationId,
                ID = partnerId,
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckExistTPartner", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public async Task<bool> IsExistsUnitPrice(long locationId, long branchId, long id)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                LocationID = locationId,
                BranchID = branchId,
                ID = id,
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckExistsUnitPrice", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public async Task<bool> IsPiInDevice(string deviceName, long id, int Type)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                DeviceName = deviceName,
                ID = id,
                Type = Type,
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckExistsTubeDetailInDevice", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public async Task<bool> IsPlanInside(string plan)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                Plans = plan,
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckPlansInside", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public async Task<bool> IsSectionInBellow(long sectionId, long bellowId, int type)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                SectionID = sectionId,
                BellowID = bellowId,
                Type = type,
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckSectionInBellow", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public async Task<bool> IsTArray(int valueId, int type)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                ValueID = valueId,
                Type = type,
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckExistsTArray", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public async Task<bool> IsTList(int id, int type)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                ID = id,
                Type = type,
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckExistsTList", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public bool IsYearStartFinish(int year)
        {
            List<int> listYear = new List<int>();
            int pYear = DateTime.Now.Year;
            for (int i = 1999; i <= pYear; i++)
            {
                listYear.Add(i);
            }
            return Array.Exists(listYear.ToArray(), element => element == year);
        }

        public async Task<bool> IsExistLocation(long locationId)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                LocationID = locationId,

            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckExistsLocation", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }

        public async Task<bool> IsExistBranch(long locationId, int branchId)
        {
            using var conn = new SqlConnection(_connectionPortObject);
            var inputParam = new DynamicParameters(new
            {
                LocationID = locationId,
                BranchID = branchId,
            });
            inputParam.Add("Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await conn.ExecuteAsync("INFPortObject.dbo.fpt_sp_CheckExistsBranch", inputParam, commandType: CommandType.StoredProcedure);
            return inputParam.Get<int>("Result") == 1;
        }
    }
}
