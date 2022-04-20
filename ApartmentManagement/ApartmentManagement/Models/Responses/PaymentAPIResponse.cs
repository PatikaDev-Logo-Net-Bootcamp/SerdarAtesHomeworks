namespace ApartmentManagement.Models.Responses
{
    public class PaymentAPIResponse<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }

    }
}
