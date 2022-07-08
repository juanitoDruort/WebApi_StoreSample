using Dapper;
using Models.Dto;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ImpRepository
{
    internal class SaleRepository : ISaleRepository
    {
        private readonly IDbConnection _DbConnection;
        public SaleRepository(IDbConnection DbConnection)
        {
            _DbConnection = DbConnection;
        }

        public async Task<IEnumerable<DtoClientsOrders>> GetClientsOrdersByCustid(int Custid)
        {
            string Qry = "SP_GET_CLIENTS_ORDERS";
            return await _DbConnection.QueryAsync<DtoClientsOrders>(Qry, new { Custid = Custid }, commandType: CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<DtoSalesDatePrediction>> GetSalesDatePredictionByCustid(int Custid)
        {
            string Qry = "SP_GET_SALES_PREDICTION";
            return await _DbConnection.QueryAsync<DtoSalesDatePrediction>(Qry, new { Custid = Custid }, commandType: CommandType.StoredProcedure);
        }       

        public async Task<bool> Save(DtoSaveOrder DtoSaveOrder)
        {
            string Qry = "SAVE_ORDER";
            int Result = await _DbConnection.ExecuteAsync(Qry, DtoSaveOrder, commandType: CommandType.StoredProcedure);
            return Result >= 1 ? true : false;
        }

        public async Task<IEnumerable<DtoShipper>> GetAllShipper()
        {
            string Qry = "SP_GET_SHIPPERS";
            return await _DbConnection.QueryAsync<DtoShipper>(Qry, commandType: CommandType.StoredProcedure);
        }
    }
}
