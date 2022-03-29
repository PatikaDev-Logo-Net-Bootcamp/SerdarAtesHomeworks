using Homeworkfour.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkfour.Business.Abstract
{
    public interface IUserService
    {
        List<Users> GetAllUsers();
        void AddUser(Users user);
        void UpdateUser(Users user);

        void DeleteUser(Users user);
    }
}
