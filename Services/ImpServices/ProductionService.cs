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
    public class ProductionService : IProductionService
    {
        private readonly IProductionRepository _IProductionRepository;
        public ProductionService( IProductionRepository IProductionRepository)
        {
            _IProductionRepository=IProductionRepository;
        }
        public async Task<IEnumerable<DtoProduct>> GetAllProdut()
        {
           return await _IProductionRepository.GetAllProdut();
        }
    }
}
