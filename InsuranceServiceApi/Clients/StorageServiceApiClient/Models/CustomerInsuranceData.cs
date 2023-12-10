namespace InsuranceServiceApi.Clients.StorageServiceClient.Models
{
    //The data suffix is be able to see the differences from InsuranceService models and client models.
    //This objects will be converted to a response object before it reach the caller.
    public class CustomerInsuranceData
    {
        public int Id{get;set;}
        public string CustomerNumber { get; set; }       
        public string CustomerName{get;set;}    
        public string EmailAddress{get; set;} 
        public string? HairColor{get;set;}

        public string InsuranceName{get;set;}
        public string InsuredAmount{get;set;}
    }
    
}