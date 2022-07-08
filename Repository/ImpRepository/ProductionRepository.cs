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
    public class ProductionRepository : IProductionRepository
    {
        private readonly IDbConnection _DbConnection;
        public ProductionRepository(IDbConnection DbConnection)
        {
            _DbConnection = DbConnection;
        }
        public async Task<IEnumerable<DtoProduct>> GetAllProdut()
        {
            string Qry = "SP_GET_PRODUCTS";
            return await _DbConnection.QueryAsync<DtoProduct>(Qry, commandType: CommandType.StoredProcedure);
        }
    }
}
