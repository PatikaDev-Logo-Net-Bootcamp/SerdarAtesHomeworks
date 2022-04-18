using ApartmentManagement.Domain;
using ApartmentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Business.Abstracts
{
    public interface IMessageService
    {
        Task<List<ApplicationUser>> GetUsersAsync(ClaimsPrincipal User);
        Task<ApplicationUser> GetUserDetailsAsync(string userId);
        Task<int> SaveMessageAsync(Message message);
        Task<List<Message>> GetConversationAsync(ClaimsPrincipal User,string contactId);


    }
}
