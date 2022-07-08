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
    public class EmployeRepository : IEmployeRepository
    {
        private readonly IDbConnection _DbConnection;
        public EmployeRepository(IDbConnection DbConnection)
        {
            _DbConnection = DbConnection;
        }
        public async Task<IEnumerable<DtoEmploye>> GetAllEmploye()
        {
            string Qry = "SP_GET_EMPLOYEES";
            return await _DbConnection.QueryAsync<DtoEmploye>(Qry, commandType: CommandType.StoredProcedure);
        }
    }
}
