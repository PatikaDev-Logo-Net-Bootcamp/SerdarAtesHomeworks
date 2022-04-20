namespace ApartmentManagement.PaymentAPI.Models
{
    public class MongoDbModel
    {
        public string DbName { get; set; }
        public string ConnectionString { get; set; }
        public string InvoicePaymentCollection { get; set; }
        public string CreditCardInfoCollection { get; set; }
    }
}
