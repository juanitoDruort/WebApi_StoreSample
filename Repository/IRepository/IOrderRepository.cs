using Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IOrderRepository
    {
        Task<IEnumerable<DtoClientsOrders>> GetClientsOrdersByCustid(int Custid);   
        Task<bool> Save(DtoSaveOrder DtoSaveOrder);        
    }
}
