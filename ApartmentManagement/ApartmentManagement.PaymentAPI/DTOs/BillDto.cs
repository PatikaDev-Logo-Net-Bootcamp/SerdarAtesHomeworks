using MongoDB.Bson.Serialization.Attributes;

namespace ApartmentManagement.PaymentAPI.DTOs
{
    public class BillDto
    {
     
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string CardNumber { get; set; }
        public int ValidMonth { get; set; }
        public int ValidYear { get; set; }
        public int Cvv { get; set; }
        public int ExpenseId { get; set; }
        public decimal Price { get; set; }
    }
}
