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
    public class ShipperRepository: IShipperRepository
    {
        private readonly IDbConnection _DbConnection;
        public ShipperRepository(IDbConnection DbConnection)
        {
            _DbConnection = DbConnection;
        }

        public async Task<IEnumerable<DtoShipper>> GetAllShipper()
        {
            string Qry = "SP_GET_SHIPPERS";
            return await _DbConnection.QueryAsync<DtoShipper>(Qry, commandType: CommandType.StoredProcedure);
        }
    }
}
