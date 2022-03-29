using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Homeworkfour.Business.DTOs;
using Homeworkfour.Business.Concretes;
using Homeworkfour.Business.Abstract;
using Homeworkfour.Models;
using System.Collections.Generic;

namespace Homeworkfour.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IJwtService jwtService;

        public UserController(IJwtService jwtService)
        {
            this.jwtService = jwtService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = new List<string>
            {
                "John Doe",
                "Samet Kayıkcı",
                "Bill Gates"
            };
            return Ok(users);
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public IActionResult Authenticate(UserModel model)
        {
            var token = jwtService.Authenticate(
                new UserDTO
                {
                    Name = model.userame,
                    Password = model.password
                }
                );

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }
    }
}
