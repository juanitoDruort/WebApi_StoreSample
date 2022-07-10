using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace WebApi_StoreSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _ICustomerService;
        public CustomerController(ICustomerService ICustomerService)
        {
            _ICustomerService = ICustomerService;
        }
        [HttpGet("GetSalesDatePrediction")]
        public async Task<ActionResult> GetSalesDatePrediction()
        {
            return Ok(await _ICustomerService.GetSalesDatePrediction());
        }
    }
}
