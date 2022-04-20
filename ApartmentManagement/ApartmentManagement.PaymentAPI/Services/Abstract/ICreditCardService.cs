using ApartmentManagement.PaymentAPI.DTOs;
using ApartmentManagement.PaymentAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApartmentManagement.PaymentAPI.Services.Abstract
{
    public interface ICreditCardService
    {
        Task<List<CreditCart>> GetAllAsync();
        Task<CreditCart> GetByFilter(BillDto filter);
        Task Add(CreditCart creditCart);
        Task Update(string id, CreditCart creditCardInfo);
    }
}
