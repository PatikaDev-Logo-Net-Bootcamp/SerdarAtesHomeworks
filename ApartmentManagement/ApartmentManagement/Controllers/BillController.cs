using ApartmentManagement.Business.Abstracts;
using ApartmentManagement.Business.DTOs;
using ApartmentManagement.Domain;
using ApartmentManagement.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ApartmentManagement.Controllers
{
    public class BillController : Controller
    {
        private readonly IBillService billService;
        private readonly IFlatService flatService;
        private readonly IBillTypeService billTypeService;
        private readonly UserManager<ApplicationUser> userManager;

        public BillController(IBillService billService, IFlatService flatService, IBillTypeService billTypeService, UserManager<ApplicationUser> userManager)
        {
            this.billService = billService;
            this.flatService = flatService;
            this.billTypeService = billTypeService;
            this.userManager= userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var bills = billService.GetAllBillsWithFlatsAndUsers();
            return View(bills);
        }



        [HttpGet]
        public IActionResult AddBill()
        {
            var flats = flatService.GetAllFlats();
            var billtypes = billTypeService.GetAllBillType();
            var elements = new BillAddDto
            {
                Flat=flats,
                BillType=billtypes,
            };
            return View(elements);
        }
        
        [HttpPost]
        public IActionResult AddBill ([FromForm] BillAddDto bill)
        {
            var bills = new Bill
            {
                BillDate=bill.BillDate,
                BillTypeId=bill.BillTypeId,
                FlatId=bill.FlatId,
                Price=bill.Price,
                
            };
            billService.AddBill(bills);
            return RedirectToAction("Index", "Bill");
        }
        [HttpPost]
        public IActionResult AddBillMultiple([FromForm] BillAddDto bill)
        {
      
            var flats = flatService.GetAllFlats();
            for (int i = 0; i < flats.Count; i++)
            {
                var bills = new Bill()
                {
                    BillDate = bill.BillDate,
                    BillTypeId = bill.BillTypeId,
                    FlatId = flats[i].Id,
                    Price = bill.Price,
                };

                billService.AddBill(bills);
            }
            return RedirectToAction("Index", "Bill");
        }
        [HttpGet]
        public IActionResult UpdateBill(int id)
        {
            var model = billService.GetAllBillsWithFlatsAndUsers().ToList().Where(x=>x.Id==id).FirstOrDefault();
            var flats = flatService.GetAllFlats();
            var billtypes = billTypeService.GetAllBillType();
            var elements = new BillUpdateDto
            {
                FlatNumber=model.FlatNumber,
                BillTypeName=model.BillTypeName,
                BillDate=model.BillDate,
                Price=model.Price,
                Flat = flats,
                BillType = billtypes,
                IsActive=model.IsActive
            };
            return View(elements);
        }
        [HttpPost]
        public IActionResult UpdateBill([FromForm] BillUpdateDto bill)
        {
            var bills = new Bill
            {
                Id = bill.Id,
                BillDate = bill.BillDate,
                BillTypeId=bill.BillTypeId,
                FlatId = bill.FlatId,
                IsActive=bill.IsActive,
                Price=bill.Price,
            };
            billService.UpdateBill(bills);
            return RedirectToAction("Index", "Bill");
        }
    
        [HttpGet]
        public async Task<IActionResult> GetUserPaidBills()
        {

            var current_User = await userManager.GetUserAsync(HttpContext.User);
            var bills = billService.GetAllBillsWithFlatsAndUsers().Where(x => x.IsActive == true && x.UserId==current_User.Id).ToList();
            return View(bills);
        }
        [HttpGet]
        public async Task<IActionResult> GetUserNotPaidBills()
        {

            var current_User = await userManager.GetUserAsync(HttpContext.User);
            var bills = billService.GetAllBillsWithFlatsAndUsers().Where(x => x.IsActive == false && x.UserId == current_User.Id).ToList();
            return View(bills);
        }
    }
}
