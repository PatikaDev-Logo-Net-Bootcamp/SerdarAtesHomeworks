using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Homeworkfour.Business.DTOs;
using Homeworkfour.Business.Concretes;
using Homeworkfour.Business.Abstract;

namespace Homeworkfour.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IJwtService jwtService;

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
