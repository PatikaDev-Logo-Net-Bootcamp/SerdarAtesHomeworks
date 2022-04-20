namespace ApartmentManagement.PaymentAPI.Responses
{
    public class ApiResponse
    {
        public object Data { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
    }
}