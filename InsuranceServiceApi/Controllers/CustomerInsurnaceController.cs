using InsuranceServiceApi.Clients.StorageServiceClient.Interfaces;
using InsuranceServiceApi.Requests;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceServiceApi.Controllers
{
    [ApiController]
    [Route("api/customerinsurances")]
    public class CustomerInsuranceController : ControllerBase
    {
        private IStorageServiceApiClient _storageClient;
        public CustomerInsuranceController(IStorageServiceApiClient storageClient)
        {
            _storageClient = storageClient;
        }
    [HttpGet("customerNumber")]
    public async Task<IActionResult> GetCustomerInsuranceAsync(string customerNumber)
    {       

        //Should be validation on the cusomernumber!
        //If non valid customerNumber than we can return a BadRequest().
        var response = await _storageClient.GetCustomerInsuranceAsync(customerNumber);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCustomerInsuranceAsync([FromBody] CreateCustomerInsuranceRequest request)
    {
        return Ok();
    }

    }
}