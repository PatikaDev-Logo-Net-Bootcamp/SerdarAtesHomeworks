namespace ApartmentManagement.PaymentAPI.DTOs
{
    public class CreditCartDto
    {
        public string CardNumber { get; set; }
        public int ValidMonth { get; set; }
        public int ValidYear { get; set; }
        public int Cvv { get; set; }
        public decimal Balance { get; set; }
    }
}
