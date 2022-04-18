using ApartmentManagement.PaymentAPI.Entities;
using ApartmentManagement.PaymentAPI.Services.Abstract;

namespace ApartmentManagement.PaymentAPI.DataAcces.Abstract
{
    public interface ICreditCardDal : IRepository<CreditCart,string>
    {

    }
}
