using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace WebApi_StoreSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _IOrderService;
        public OrderController(IOrderService OrderService)
        {
            _IOrderService = OrderService;
        }

        [HttpGet("GetClientsOrdersByCustid")]
        public async Task<ActionResult> GetClientsOrdersByCustid(int Custid)
        {
            return Ok(await _IOrderService.GetClientsOrdersByCustid(Custid));
        }
    }
}
