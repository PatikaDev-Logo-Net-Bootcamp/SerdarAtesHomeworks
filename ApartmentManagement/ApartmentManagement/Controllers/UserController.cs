using ApartmentManagement.Business.Abstracts;
using ApartmentManagement.Business.DTOs;
using ApartmentManagement.Domain;
using ApartmentManagement.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace ApartmentManagement.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IEmailSender _emailSender;
        private readonly IBillService billService;
        private readonly HttpClient _httpClient;

        public UserController(UserManager<ApplicationUser> userManager, IEmailSender emailSender, IBillService billService, HttpClient httpClient)
        {
            this.userManager = userManager;
            _emailSender = emailSender;
            this.billService = billService;
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = await userManager.Users.ToListAsync();
            List<UserDto> usersDto = new List<UserDto>();
            foreach (var user in users)
            {
                usersDto.Add(new UserDto
                {
                    Id = user.Id,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    TcNo = user.TcNumber,
                    CarPlateNumber = user.CarPlateNumber,
                    
                }
               );
            }
            return View(usersDto);
        }
        [HttpPost]
        public async Task<IActionResult> AddUser([FromForm] UserAddDto userform)
        {
            MailAddress mail = new MailAddress(userform.Email);
            string userName = mail.User;
            var user = new ApplicationUser
            {
                UserName = userName,
                Email = userform.Email,
                FirstName = userform.FirstName,
                LastName = userform.LastName,
                TcNumber=userform.TcNo,
                CarPlateNumber=userform.CarPlateNumber
            };
            var result = await userManager.CreateAsync(user, userform.Password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "Basic");
                return RedirectToAction("Index","User");
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateUserAsync(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            var userdto = new UserAddDto {
            Id = user.Id,
            CarPlateNumber=user.CarPlateNumber,
            Email=user.Email,
            FirstName=user.FirstName,
            LastName = user.LastName,
            TcNo=user.TcNumber
            };
            return View(userdto);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUserAsync([FromForm] UserAddDto userform)
        {
            var user = await userManager.FindByIdAsync(userform.Id);
            MailAddress mail = new MailAddress(userform.Email);
            string userName = mail.User;
            user.UserName = userName;
            user.Email = userform.Email;
            user.FirstName = userform.FirstName;
            user.LastName = userform.LastName;
            user.TcNumber = userform.TcNo;
            user.CarPlateNumber = userform.CarPlateNumber;
            var result = await userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "User");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> DeleteUserAsync(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            var result = await userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "User");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetUserPaidBills()
        {

            var current_User = await userManager.GetUserAsync(HttpContext.User);
            var bills = billService.GetAllBillsWithFlatsAndUsers().Where(x => x.IsActive == true && x.UserId == current_User.Id).ToList();
            return View(bills);
        }
        [HttpGet]
        public async Task<IActionResult> GetUserNotPaidBills()
        {
            var current_User = await userManager.GetUserAsync(HttpContext.User);
            var bills = billService.GetAllBillsWithFlatsAndUsers().Where(x => x.IsActive == false && x.UserId == current_User.Id).ToList();
            return View(bills);
        }
        [HttpPost]
        public async Task<IActionResult> AddPayment(PaymentDto AddPaymentDto)
        {
            var getBill = billService.GetAllBill().Where(x=>x.Id==AddPaymentDto.BillId).FirstOrDefault();
            AddPaymentDto.Price = getBill.Price;
            AddPaymentDto.FlatId = getBill.FlatId;
            AddPaymentDto.BillId = getBill.Id;

            string requestUrl = "https://localhost:44315/api/Payment/AddPayment";
            HttpResponseMessage httpResponse;

            string requestJson = JsonConvert.SerializeObject(AddPaymentDto);
            using (var stringContent = new StringContent(requestJson, Encoding.UTF8, "application/json"))
            {
                httpResponse = await _httpClient.PostAsync(requestUrl, stringContent);
                var apiResponse = await httpResponse.Content.ReadAsStringAsync();
                var resp=JsonConvert.DeserializeObject<PaymentAPIResponse<string>>(apiResponse);
                if (resp.StatusCode == StatusCodes.Status200OK)
                {
                    getBill.IsActive = true;
                    billService.UpdateBillPayment(getBill);

                    return RedirectToAction("GetUserNotPaidBills");
                }
                return RedirectToAction("GetUserNotPaidBills");
            }
        }
        [HttpGet]
        public IActionResult AddPayment(int id)
        {
            var getBill = billService.GetAllBill().Where(x => x.Id == id).FirstOrDefault();
            return View(new PaymentDto
            {
                BillId = getBill.Id,
                FlatId= getBill.FlatId,
                Price=getBill.Price
            });
        }





    }
}