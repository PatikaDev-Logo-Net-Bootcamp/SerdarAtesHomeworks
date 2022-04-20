using ApartmentManagement.PaymentAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApartmentManagement.PaymentAPI.Services.Abstract
{
    public interface IBillPaymentService
    {

        Task AddPayment(BillPayment billPayment);
   
    }
}
