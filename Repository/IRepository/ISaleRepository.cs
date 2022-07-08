using Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface ISaleRepository
    {
        Task<IEnumerable<DtoClientsOrders>> GetClientsOrdersByCustid(int Custid);
        Task<IEnumerable<DtoSalesDatePrediction>> GetSalesDatePredictionByCustid(int Custid);
        Task<IEnumerable<DtoShipper>> GetAllShipper();
        Task<bool> Save(DtoSaveOrder DtoSaveOrder);        
    }
}
