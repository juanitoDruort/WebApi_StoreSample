using Microsoft.AspNetCore.Mvc;
using Services.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi_StoreSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class ProductController : ControllerBase
    {
        private readonly IProductionService _IProductionService;
        public ProductController(IProductionService ProductionService)
        {
            _IProductionService=ProductionService;
        }

        [HttpGet("GetAllProdut")]
        public async Task<ActionResult> GetAllProdut()
        {
            return Ok(await _IProductionService.GetAllProdut());
        }
    }
}
