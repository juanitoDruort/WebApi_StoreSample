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
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _OrderRepository;
        public OrderService(IOrderRepository OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }
        public async Task<IEnumerable<DtoClientsOrders>> GetClientsOrdersByCustid(int custid)
        {
            return await _OrderRepository.GetClientsOrdersByCustid(custid);
        }

        

        public async Task<bool> Save(DtoSaveOrder DtoSaveOrder)
        {
           return await _OrderRepository.Save(DtoSaveOrder);
        }
    }
}
