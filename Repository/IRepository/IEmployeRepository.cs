using Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IEmployeRepository
    {
        Task<IEnumerable<DtoEmploye>> GetAllEmploye();
    }
}
