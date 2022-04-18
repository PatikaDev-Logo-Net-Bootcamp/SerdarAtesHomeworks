namespace ApartmentManagement.PaymentAPI.Models
{
    public class MongoDbModel
    {
        public string ConnectionString;
        public string Database;
        public const string ConnectionStringValue = nameof(ConnectionString);
        public const string DatabaseValue = nameof(Database);
    }
}
