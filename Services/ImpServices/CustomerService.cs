using Models.Dto;
using Repository.IRepository;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ImpServices
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _ICustomerRepository;
        public CustomerService(ICustomerRepository ICustomerRepository)
        {
            _ICustomerRepository= ICustomerRepository;
        }
        public async Task<IEnumerable<DtoSalesDatePrediction>> GetSalesDatePrediction()
        {
            return await _ICustomerRepository.GetSalesDatePrediction();
        }
    }
}
