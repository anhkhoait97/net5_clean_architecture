using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Shop.Application.Interfaces.INFPortObject;
using Shop.Application.Interfaces.Shared;
using Shop.Domain.Entities.INFPortObject;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Repositories.INFPortObject
{
    public class TacitRepository : ITacitRepository
    {
        private readonly IRepositoryAsync.INFPortObject _repository;

        public TacitRepository(IRepositoryAsync.INFPortObject repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Tacit>> GetTacitsAsync()
        {
            return await _repository.ListAsync<Tacit>();
        }

        public async Task<long> AddTacit(Tacit tacit)
        {
            using var connection = new SqlConnection(_repository.StrConnect);
            var inputParam = new DynamicParameters(new
            {
                Code = tacit.Code,
                Name = tacit.Name,
                LocationID = tacit.LocationID,
                BranchID = tacit.BranchID,
                Plans = tacit.Plans,
                INFMaintail = tacit.INFMaintail,
                Street = tacit.Street,
                Street_District = tacit.Street_District,
                Street_Ward = tacit.Street_Ward,
                StartName = tacit.StartName,
                StartName_District = tacit.StartName_District,
                StartName_Ward = tacit.StartName_Ward,
                EndName = tacit.EndName,
                EndName_District = tacit.EndName_District,
                EndName_Ward = tacit.EndName_Ward,
                Length = tacit.Length,
                Invest_Costs = tacit.Invest_Costs,
                Rental_Cost = tacit.Rental_Cost,
                StartUp_Quarter = tacit.StartUp_Quarter,
                StartUp_Year = tacit.StartUp_Year,
                Finish_Quarter = tacit.Finish_Quarter,
                Finish_Year = tacit.Finish_Year,
                InvestID = tacit.InvestID,
                ManagerUnitID = tacit.ManagerUnitID,
                LinkDesign = tacit.LinkDesign,
                Description = tacit.Description,
                CreateBy = tacit.CreateBy,
                TypeBuilding = tacit.TypeBuilding,
                BuildingID = tacit.BuildingID,
                BuildingName = tacit.BuildingName,
                IsFile = tacit.IsFile,
                FileNameHistory = "test",
                TypeTacit = tacit.TypeTacit,
            });
            inputParam.Add("Result", dbType: DbType.Int64, direction: ParameterDirection.Output);
            await connection.ExecuteAsync("fpt_spAdd_Tacit", inputParam, commandType: CommandType.StoredProcedure);
            var result = inputParam.Get<long>("Result");
            return result;
        }

        public async Task<long> UpdateTacit(Tacit tacit)
        {
            using var connection = new SqlConnection(_repository.StrConnect);
            var inputParam = new DynamicParameters(new
            {
                Code = tacit.Code,
                Name = tacit.Name,
                LocationID = tacit.LocationID,
                BranchID = tacit.BranchID,
                Plans = tacit.Plans,
                INFMaintail = tacit.INFMaintail,
                Street = tacit.Street,
                Street_District = tacit.Street_District,
                Street_Ward = tacit.Street_Ward,
                StartName = tacit.StartName,
                StartName_District = tacit.StartName_District,
                StartName_Ward = tacit.StartName_Ward,
                EndName = tacit.EndName,
                EndName_District = tacit.EndName_District,
                EndName_Ward = tacit.EndName_Ward,
                Length = tacit.Length,
                Invest_Costs = tacit.Invest_Costs,
                Rental_Cost = tacit.Rental_Cost,
                StartUp_Quarter = tacit.StartUp_Quarter,
                StartUp_Year = tacit.StartUp_Year,
                Finish_Quarter = tacit.Finish_Quarter,
                Finish_Year = tacit.Finish_Year,
                InvestID = tacit.InvestID,
                ManagerUnitID = tacit.ManagerUnitID,
                LinkDesign = tacit.LinkDesign,
                Description = tacit.Description,
                UpdateBy = tacit.UpdateBy,
                ID = tacit.ID,
                TypeBuilding = tacit.TypeBuilding,
                BuildingID = tacit.BuildingID,
                BuildingName = tacit.BuildingName,
                IsFile = tacit.IsFile,
                FileNameHistory = "test",
                TypeTacit = tacit.TypeTacit,
            });
            inputParam.Add("Result", dbType: DbType.Int64, direction: ParameterDirection.Output);
            await connection.ExecuteAsync("fpt_spUpdate_Tacit_ID", inputParam, commandType: CommandType.StoredProcedure);
            var result = inputParam.Get<long>("Result");
            return result;
        }
    }
}
