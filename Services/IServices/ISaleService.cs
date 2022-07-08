using Models.Core.Sales;
using Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface ISaleService
    {
        Task<IEnumerable<DtoSalesDatePrediction>> GetSalesDatePrediction(int custid);
        Task<IEnumerable<DtoClientsOrders>> GetClientsOrdersByCustid(int custid);
        Task<IEnumerable<DtoShipper>> GetAllShipper();
        Task<bool> Save(DtoSaveOrder DtoSaveOrder);
    }
}
