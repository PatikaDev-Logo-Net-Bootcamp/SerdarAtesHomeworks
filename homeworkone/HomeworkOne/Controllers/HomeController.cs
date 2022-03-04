using HomeworkOne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkOne.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // return succes
                return Success();
                //return Ok(new ResponseModel { Succes=true,Data = "giriş işlemi başarılı ", Error=false});
            }
            else
            {
                //return false
                return False();
               //return BadRequest(new ResponseModel { Error=true,Succes=false,Data="Hatalı Giriş"});
            }

           
        }
        public IActionResult Success()
        {
            return Ok(new ResponseModel { Data = "giriş işlemi başarılı", Succes = true, Error = null });
        }
        public IActionResult False()
        {
            return BadRequest(new ResponseModel { Data = null, Succes = false, Error = "hatalı giriş" });
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
