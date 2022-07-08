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
    public class EmployeService : IEmployeService
    {
        public IEmployeRepository _IEmployeRepository;
        public EmployeService(IEmployeRepository EmployeRepository)
        {
            _IEmployeRepository = EmployeRepository;
        }
        public async Task<IEnumerable<DtoEmploye>> GetAllEmploye()
        {
            return await _IEmployeRepository.GetAllEmploye();
        }
    }
}
