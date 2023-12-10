namespace InsuranceServiceApi.Responses
{
    public class CustomerInsuranceResponse
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