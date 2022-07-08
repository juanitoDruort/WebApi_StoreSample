using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace WebApi_StoreSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class EmployeController : ControllerBase
    {
        private readonly IEmployeService _IEmployeService;
        public EmployeController(IEmployeService IEmployeService)
        {
            _IEmployeService= IEmployeService;
        }
        [HttpGet("GetAllEmploye")]
        public async Task<ActionResult> GetAllEmploye()
        {
            return Ok(await _IEmployeService.GetAllEmploye());
        }
    }
}
