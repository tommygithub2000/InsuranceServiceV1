using System.ComponentModel.DataAnnotations;

namespace InsuranceServiceApi.Requests
{
    public class CreateCustomerInsuranceRequest
    {
        //Add first line check on indata with data annotations
        [Required]
        [StringLength(12, MinimumLength = 10, ErrorMessage = "Customer number length should be between 10 and 12 long")]
        public string CustomerNumber { get; set; }       
        public string CustomerName{get;set;}    
        public string EmailAddress{get; set;} 
        public string? HairColor{get;set;}

        public string InsuranceName{get;set;}
        public string InsuredAmount{get;set;}
    }
}