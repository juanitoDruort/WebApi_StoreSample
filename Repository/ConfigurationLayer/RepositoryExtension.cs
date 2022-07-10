using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Repository.ImpRepository;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ConfigurationLayer
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepository(this IServiceCollection Services, IConfiguration Configuration)
        {            
            string StringConnection = Configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
            Services.AddTransient<IDbConnection>((sp) => new SqlConnection(StringConnection));
            Services.TryAddScoped<IOrderRepository, OrderRepository>();
            Services.TryAddScoped<IEmployeRepository, EmployeRepository>();
            Services.TryAddScoped<IProductionRepository, ProductionRepository>();
            Services.TryAddScoped<ICustomerRepository, CustomerRepository>();
            Services.TryAddScoped<IShipperRepository, ShipperRepository>();         
            return Services;
        }
    }
}
