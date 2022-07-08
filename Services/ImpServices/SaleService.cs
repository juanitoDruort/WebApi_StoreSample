using Repository.IRepository;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Core.Sales;
using Dapper;
using Models.Dto;

namespace Services.ImpServices
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _OrderRepository;
        public SaleService(ISaleRepository OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }

        public async Task<IEnumerable<DtoShipper>> GetAllShipper()
        {
            return await _OrderRepository.GetAllShipper();
        }

        public async Task<IEnumerable<DtoClientsOrders>> GetClientsOrdersByCustid(int custid)
        {
            return await _OrderRepository.GetClientsOrdersByCustid(custid);
        }

        public async Task<IEnumerable<DtoSalesDatePrediction>> GetSalesDatePrediction(int custid)
        {
            return await _OrderRepository.GetSalesDatePredictionByCustid(custid);
        }

        public async Task<bool> Save(DtoSaveOrder DtoSaveOrder)
        {
           return await _OrderRepository.Save(DtoSaveOrder);
        }
    }
}
