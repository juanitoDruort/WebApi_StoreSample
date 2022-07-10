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
    internal class OrderRepository : IOrderRepository
    {
        private readonly IDbConnection _DbConnection;
        public OrderRepository(IDbConnection DbConnection)
        {
            _DbConnection = DbConnection;
        }

        public async Task<IEnumerable<DtoClientsOrders>> GetClientsOrdersByCustid(int Custid)
        {
            string Qry = "SP_GET_CLIENTS_ORDERS";
            return await _DbConnection.QueryAsync<DtoClientsOrders>(Qry, new { Custid = Custid }, commandType: CommandType.StoredProcedure);
        }          

        public async Task<bool> Save(DtoSaveOrder DtoSaveOrder)
        {
            string Qry = "SAVE_ORDER";
            int Result = await _DbConnection.ExecuteAsync(Qry, DtoSaveOrder, commandType: CommandType.StoredProcedure);
            return Result >= 1 ? true : false;
        }      
    }
}
