using InsuranceServiceApi.Clients.StorageServiceClient.Interfaces;
using InsuranceServiceApi.Clients.StorageServiceClient.Models;
using InsuranceServiceApi.Requests;

namespace InsuranceServiceApi.Clients.StorageServiceClient
{
    /// <summary>
    /// This client is coded by hand. I have mostly worked in environments that have framework for generating this clients and models from rest APIs.
    /// </summary>
    public class StorageServiceApiClient : IStorageServiceApiClient
    {
        private readonly HttpClient _httpClient;

        public StorageServiceApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient)); //Nice to give an early indication on an error.
        }

        public async Task<CustomerInsuranceData> CreateCustomerInsuranceAsync(CreateCustomerInsuranceRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomerInsuranceData> GetCustomerInsuranceAsync(string customernumber)
        {
            string endpoint = $"/api/customerinsurances/{customernumber}";
        
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(endpoint);

                //The error handling may need some more thinking!
                if (response.IsSuccessStatusCode)
                {
                    CustomerInsuranceData customerInsurance = await response.Content.ReadFromJsonAsync<CustomerInsuranceData>();

                    return customerInsurance; //Should be a transformation here to a response object. 
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return null; //Should be someting else than just null. Otherwise we cant tell if we did not find a customer or some error occured.
                }
            }catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message} InnerException: {ex.InnerException}");
                throw;
            }
        }
    }
}