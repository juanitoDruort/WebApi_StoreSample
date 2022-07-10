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
    public class ShipperService:IShipperService
    {
        private readonly IShipperRepository _IShipperRepository;
        public ShipperService(IShipperRepository IShipperRepository)
        {
            _IShipperRepository = IShipperRepository;
        }
        public async Task<IEnumerable<DtoShipper>> GetAllShipper()
        {
            return await _IShipperRepository.GetAllShipper();
        }
    }
}
