using Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IProductionRepository
    {
        Task<IEnumerable<DtoProduct>> GetAllProdut();
    }
}
