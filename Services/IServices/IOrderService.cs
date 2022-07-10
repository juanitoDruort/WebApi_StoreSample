using Models.Core.Sales;
using Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IOrderService
    {       
        Task<IEnumerable<DtoClientsOrders>> GetClientsOrdersByCustid(int custid);
        Task<bool> Save(DtoSaveOrder DtoSaveOrder);
    }
}
