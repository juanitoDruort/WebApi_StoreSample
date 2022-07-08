using Microsoft.AspNetCore.Mvc;
using Models.Dto;
using Services.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi_StoreSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class Sale : ControllerBase
    {
        private readonly ISaleService _IOrderService;
        public Sale(ISaleService OrderService)
        {
            _IOrderService = OrderService;
        }

        [HttpGet("GetSalesDatePrediction")]
        public async Task<ActionResult> GetSalesDatePrediction(int Custid)
        {
            return  Ok( await _IOrderService.GetSalesDatePrediction(Custid));
        }

        [HttpGet("GetClientsOrdersByCustid")]
        public async Task<ActionResult> GetClientsOrdersByCustid(int Custid)
        {
            return Ok(await _IOrderService.GetClientsOrdersByCustid(Custid));
        }


        [HttpGet("GetAllShipper")]
        public async Task<ActionResult> GetAllShipper()
        {
            return Ok(await _IOrderService.GetAllShipper());
        }

        [HttpPost("Save")]
        public async Task<ActionResult> Save(DtoSaveOrder DtoSaveOrder)
        {
            if (await _IOrderService.Save(DtoSaveOrder))
            {
                return Created("", DtoSaveOrder);
            }
            else {
                return BadRequest();
            }
            
        }
    }
}
