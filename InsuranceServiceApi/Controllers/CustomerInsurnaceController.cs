using InsuranceServiceApi.Requests;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceServiceApi.Controllers
{
    [ApiController]
    [Route("api/customerinsurances")]
    public class CustomerInsuranceController : ControllerBase
    {
        public CustomerInsuranceController()
        {
            //Inject client interface to access storage.
        }
    [HttpGet("customerNumber")]
    public async Task<IActionResult> GetCustomerInsuranceAsync(string customerNumber)
    {
        return Ok();
    }

    [HttpGet("customerNumber")]
    public async Task<IActionResult> CreateCustomerInsuranceAsync(CreateCustomerInsuranceRequest request)
    {
        return Ok();
    }

    }
}