using ApartmentManagement.Business.Abstracts;
using ApartmentManagement.DataAcces.EntityFramework.Repository.Abstracts;
using ApartmentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public void AddMessage(Message message)
        {
            repository.Add(message);
            unitOfWork.Commit();
        }

        public void DeleteMessage(Message message)
        {
            repository.Delete(message);
            unitOfWork.Commit();
        }

        public List<Message> GetAllMessage()
        {
            return repository.Get().ToList();
        }
    }
}
