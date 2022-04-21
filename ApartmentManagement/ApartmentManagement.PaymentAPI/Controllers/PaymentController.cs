
using ApartmentManagement.PaymentAPI.DTOs;
using ApartmentManagement.PaymentAPI.Entities;
using ApartmentManagement.PaymentAPI.Models.Validators;
using ApartmentManagement.PaymentAPI.Responses;
using ApartmentManagement.PaymentAPI.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApartmentManagement.PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IBillPaymentService BillService;
        private readonly ICreditCardService CreditCardService;

        public PaymentController(IBillPaymentService billService, ICreditCardService creditCardService)
        {
            BillService = billService;
            CreditCardService = creditCardService;
        }

        private ApiResponse Success(string data)
        {
            return new ApiResponse
            {
                Data = data,
                Message = "İşlem başarılı",
                StatusCode = StatusCodes.Status200OK
            };
        }

        private ApiResponse Error(string errorMessage)
        {
            return new ApiResponse
            {
                Data = null,
                Message = errorMessage,
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }
        [Route("AddPayment")]
        [HttpPost]
        public async Task<ApiResponse> CreatePayment([FromBody]BillDto createPaymentDto)
        {
            var validator = new BillPaymentValidation();
            var results = validator.Validate(createPaymentDto);
            if (!results.IsValid)
            {
                return Error(results.ToString());
            }

            var creditCardResult = await CreditCardService.GetByFilter(createPaymentDto);

            if (creditCardResult == null)
            {
                return Error("Kart Bulunamadı");
            }
            if (creditCardResult.Balance < createPaymentDto.Price)
            {
                return Error("Kart bakiyesi yetersiz");
            }
            var BillPayment = new BillPayment()
            {
                CardNumber = createPaymentDto.CardNumber,
                Cvv = createPaymentDto.Cvv,
                Price = createPaymentDto.Price,
                ValidMonth = createPaymentDto.ValidMonth,
                ValidYear = createPaymentDto.ValidYear,
                BillId = createPaymentDto.ExpenseId
            };
            creditCardResult.Balance -= createPaymentDto.Price;

            await CreditCardService.Update(creditCardResult.Id, creditCardResult);
            await BillService.AddPayment(BillPayment);
            return Success(BillPayment.Id);
        }
        [Route("CreateCreditCard")]
        [HttpPost]
        public async Task<string> CreateCreditCard(CreditCartDto creditCard)
        {
            var createCreditCard = new CreditCart()
            {
                CardNumber = creditCard.CardNumber,
                Cvv = creditCard.Cvv,
                Balance = creditCard.Balance,
                ValidMonth = creditCard.ValidMonth,
                ValidYear = creditCard.ValidYear,
            };
            await CreditCardService.Add(createCreditCard);
            return "Başarılı";
        }

    }
}
