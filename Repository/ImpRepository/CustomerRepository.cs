using Dapper;
using Models.Dto;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ImpRepository
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly IDbConnection _DbConnection;
        public CustomerRepository(IDbConnection DbConnection)
        {
            _DbConnection = DbConnection;
        }
        public async Task<IEnumerable<DtoSalesDatePrediction>> GetSalesDatePrediction()
        {
            string Qry = "SP_GET_SALES_PREDICTION";
            return await _DbConnection.QueryAsync<DtoSalesDatePrediction>(Qry, commandType: CommandType.StoredProcedure);
        }
    }
}
