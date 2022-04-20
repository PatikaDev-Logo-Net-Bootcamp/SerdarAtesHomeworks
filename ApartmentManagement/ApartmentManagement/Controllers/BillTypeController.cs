using ApartmentManagement.Business.Abstracts;
using ApartmentManagement.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ApartmentManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BillTypeController : Controller
    {
        private readonly IBillTypeService billTypeService;

        public BillTypeController(IBillTypeService billTypeService)
        {
            this.billTypeService = billTypeService;
        }

  
        public IActionResult Index()
        {

            var model = billTypeService.GetAllBillType().ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddBillType([FromForm] BillType bill)
        {
            billTypeService.AddBillType(bill);
            TempData["Alert"] = "Başarıyla Eklendi";
            return RedirectToAction("Index","BillType");
        }

        [HttpGet]
        public IActionResult AddBillType()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateBillType([FromForm] BillType bill)
        {
            billTypeService.UpdateBillType(bill);
            TempData["Alert"] = "Başarıyla Düzenlendi";
            return RedirectToAction("Index", "BillType");
        }
        [HttpGet]
        public IActionResult UpdateBillType(int id)
        {
            var billType = billTypeService.GetAllBillType().ToList().Where(x=>x.Id==id).FirstOrDefault();
            return View(billType);
        }

        [HttpGet]
        public IActionResult DeleteBillType(int id)
        {

            var bill = billTypeService.GetAllBillType().ToList().Where(x => x.Id == id).FirstOrDefault();
            billTypeService.DeleteBillType(bill);
            TempData["Alert"] = "Başarıyla Silindi";
            return RedirectToAction("Index", "BillType");
        }





    }
}
