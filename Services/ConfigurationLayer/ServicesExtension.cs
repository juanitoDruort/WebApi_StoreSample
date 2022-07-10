using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Repository.ConfigurationLayer;
using Services.ImpServices;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ConfigurationLayer
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection Services, IConfiguration Configuration)
        {            
            Services.AddRepository(Configuration);
            Services.TryAddScoped<IOrderService, OrderService>();
            Services.TryAddScoped<IEmployeService, EmployeService>();
            Services.TryAddScoped<IProductionService, ProductionService>();
            Services.TryAddScoped<ICustomerService, CustomerService>();
            Services.TryAddScoped<IShipperService, ShipperService>();
            return Services;
        }
    }
}
