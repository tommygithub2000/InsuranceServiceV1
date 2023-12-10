using InsuranceServiceApi.Clients.StorageServiceClient.Models;
using InsuranceServiceApi.Requests;

namespace InsuranceServiceApi.Clients.StorageServiceClient.Interfaces
{
    //Interface to make the code more tesable. Interface is also a nice place to document the methods.
    public interface IStorageServiceApiClient
    {
        Task<CustomerInsuranceData> GetCustomerInsuranceAsync(string customerNumber);
        //The create method can receive an object but a id for the created object may be enough. Then you can choose to get it or save time 
        //when you dont return the whole object that is stored.
        Task<CustomerInsuranceData> CreateCustomerInsuranceAsync(CreateCustomerInsuranceRequest request);
    }
}