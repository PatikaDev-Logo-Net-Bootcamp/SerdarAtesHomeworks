using Homeworkfour.Business.Abstract;
using Homeworkfour.DataAccess.EntityFramework.Repository.Abstracts;
using Homeworkfour.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkfour.Business.Concretes
{
    public class UserService : IUserService
    {
        private readonly IRepository<Users> repository;
        private readonly IUnitOfWork unitOfWork;
        public UserService(IRepository<Users> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }
        public void AddUser(Users user)
        {
            repository.Add(user);
            unitOfWork.Commit();
        }

        public void DeleteUser(Users user)
        {
            repository.Delete(user);
            unitOfWork.Commit();
        }

        public List<Users> GetAllUsers()
        {
            return repository.Get().ToList();
        }

        public void UpdateUser(Users user)
        {

            repository.Update(user);
            unitOfWork.Commit();
        }
    }
}
