using ApartmentManagement.PaymentAPI.Entities;
using ApartmentManagement.PaymentAPI.Models;
using ApartmentManagement.PaymentAPI.Services.Abstract;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace ApartmentManagement.PaymentAPI.Services.Concrete
{
    public class BillPaymentService:IBillPaymentService
    {
        private IMongoCollection<BillPayment> billPaymentCollection;
        private MongoDbModel _config;

        public BillPaymentService(IOptions<MongoDbModel> config)
        {
            _config = config.Value;
            MongoClient client = new MongoClient(_config.ConnectionString);
            IMongoDatabase db = client.GetDatabase(_config.DbName);
            billPaymentCollection = db.GetCollection<BillPayment>(_config.InvoicePaymentCollection);
        }
        public async Task AddPayment(BillPayment invoicePayment)
        {
            await billPaymentCollection.InsertOneAsync(invoicePayment);
        }
    }
}
