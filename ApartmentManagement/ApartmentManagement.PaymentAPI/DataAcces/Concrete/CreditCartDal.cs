using ApartmentManagement.PaymentAPI.DataAcces.Abstract;
using ApartmentManagement.PaymentAPI.Entities;
using ApartmentManagement.PaymentAPI.Models;
using ApartmentManagement.PaymentAPI.Services.Concrete;
using Microsoft.Extensions.Options;

namespace ApartmentManagement.PaymentAPI.DataAcces.Concrete
{
    public class CreditCartDal : Repository<CreditCart>, ICreditCardDal
    {
        public CreditCartDal(IOptions<MongoDbModel> options) : base(options)
        {
        }
    }
}
