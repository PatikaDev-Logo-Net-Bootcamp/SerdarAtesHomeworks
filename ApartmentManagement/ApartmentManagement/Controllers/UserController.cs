using ApartmentManagement.Business.DTOs;
using ApartmentManagement.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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


        public UserController(UserManager<ApplicationUser> userManager, IEmailSender emailSender)
        {
            this.userManager = userManager;
            _emailSender = emailSender;
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
                    TcNo = user.TcNumber
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



    }
}