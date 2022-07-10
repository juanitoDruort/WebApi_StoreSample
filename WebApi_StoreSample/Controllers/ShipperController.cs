using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace WebApi_StoreSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class ShipperController : ControllerBase
    {
        private readonly IShipperService _IShipperService;
        public ShipperController(IShipperService IShipperService)
        {
            _IShipperService = IShipperService;
        }


        [HttpGet("GetAllShipper")]
        public async Task<ActionResult> GetAllShipper()
        {
            return Ok(await _IShipperService.GetAllShipper());
        }
    }
}
