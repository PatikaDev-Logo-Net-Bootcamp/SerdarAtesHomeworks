﻿using ApartmentManagement.Business.Abstracts;
using ApartmentManagement.DataAcces.EntityFramework;
using ApartmentManagement.Domain;
using ApartmentManagement.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ApartmentManagement.Controllers
{
    public class MessagesController : Controller
    {
        private readonly IMessageService messageService;
        private readonly UserManager<ApplicationUser> userManager;

        public MessagesController(IMessageService messageService, UserManager<ApplicationUser> userManager)
        {
            this.messageService = messageService;
            this.userManager = userManager;

        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
          
            var user = await messageService.GetUsersAsync(User);
            return View(user);
        }
        [HttpGet]
        public async Task<IActionResult> GetUserDetail()
        {
            var current_User = await userManager.GetUserAsync(HttpContext.User);
         
            return View(await messageService.GetUserDetailsAsync(current_User.Id));
        }
        [HttpPost]
        public async  Task<IActionResult> PostMessage([FromForm] Message message)
        {
            await messageService.SaveMessageAsync(message);
            return View();
        }
        public async Task<IActionResult> GetConversation(string Id)
        {
            var conversation = await messageService.GetConversationAsync(User, Id);
            return View(conversation);
        }


    }
}