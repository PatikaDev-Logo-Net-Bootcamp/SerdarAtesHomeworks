using ApartmentManagement.PaymentAPI.DTOs;
using ApartmentManagement.PaymentAPI.Entities;
using ApartmentManagement.PaymentAPI.Models;
using ApartmentManagement.PaymentAPI.Services.Abstract;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApartmentManagement.PaymentAPI.Services.Concrete
{
    public class CreditCardService: ICreditCardService
    {
        private IMongoCollection<CreditCart> _creditCardCollection;
        private MongoDbModel _config;
        public CreditCardService(IOptions<MongoDbModel> config)
        {
            _config = config.Value;
            MongoClient client = new MongoClient(_config.ConnectionString);
            IMongoDatabase db = client.GetDatabase(_config.DbName);
            _creditCardCollection = db.GetCollection<CreditCart>(_config.CreditCardInfoCollection);
        }
        public async Task<CreditCart> GetByFilter(BillDto filter)
        {
            return await _creditCardCollection.Find(x => x.CardNumber == filter.CardNumber &&
                                                              x.Cvv == filter.Cvv &&
                                                              x.ValidMonth == filter.ValidMonth &&
                                                              x.ValidYear == filter.ValidYear).FirstOrDefaultAsync();
        }
        public async Task Add(CreditCart creditCardInfo)
        {
            await _creditCardCollection.InsertOneAsync(creditCardInfo);
        }

        public async Task<List<CreditCart>> GetAllAsync()
        {
            return await _creditCardCollection.Find(x => true).ToListAsync();
        }

        public async Task Update(string id, CreditCart creditCardInfo)
        {
            await _creditCardCollection.ReplaceOneAsync(x => x.Id == id, creditCardInfo);
        }
    }
}
