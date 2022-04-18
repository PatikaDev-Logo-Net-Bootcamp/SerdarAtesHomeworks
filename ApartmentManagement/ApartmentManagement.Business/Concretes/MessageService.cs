using ApartmentManagement.Business.Abstracts;
using ApartmentManagement.DataAcces.EntityFramework.Repository.Abstracts;
using ApartmentManagement.Domain;
using ApartmentManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ApartmentManagement.Business.Concretes
{
    public class MessageService : IMessageService
    {
        private readonly IRepository<Message> repository;
        private readonly IUnitOfWork unitOfWork;

        public MessageService(IRepository<Message> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<Message>> GetConversationAsync(ClaimsPrincipal User,string contactId)
        {
            var userId = User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).FirstOrDefault();
            var messages = await unitOfWork.Context.Messages
                    .Where(h => (h.FromUserId == contactId && h.ToUserId == userId) || (h.FromUserId == userId && h.ToUserId == contactId))
                    .OrderBy(a => a.CreatedDate)
                    .Include(a => a.FromUser)
                    .Include(a => a.ToUser)
                    .Select(x => new Message
                    {
                        FromUserId = x.FromUserId,
                        Content = x.Content,
                        CreatedDate = x.CreatedDate,
                        Id = x.Id,
                        ToUserId = x.ToUserId,
                        ToUser = x.ToUser,
                        FromUser = x.FromUser
                    }).ToListAsync();
            if(messages.Count==0)
            {
                await SaveMessageAsync(User, new Message { 
                    ToUserId=contactId,
                    Content=null,
                    CreatedDate=DateTime.Now,   
                });
              return await GetConversationAsync(User,contactId);
            }
            return messages;
        }
        public async Task<ApplicationUser> GetUserDetailsAsync(string userId)
        {
            var user = await unitOfWork.Context.Users.Where(user => user.Id == userId).FirstOrDefaultAsync();
            return user;
        }

        public async Task<List<ApplicationUser>> GetUsersAsync(ClaimsPrincipal User)
        {
            var userId = User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).FirstOrDefault();
            var allUsers = await unitOfWork.Context.Users.Where(user => user.Id != userId).ToListAsync();

            return allUsers;
        }

        public async Task<int> SaveMessageAsync(ClaimsPrincipal User, Message message)
        {
            var userId = User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).FirstOrDefault();
            message.FromUserId = userId;
            message.CreatedDate = DateTime.Now;
            message.ToUser = await unitOfWork.Context.Users.Where(user => user.Id == message.ToUserId).FirstOrDefaultAsync();
            await unitOfWork.Context.Messages.AddAsync(message);
            return await unitOfWork.Context.SaveChangesAsync();
        }
    }
}
