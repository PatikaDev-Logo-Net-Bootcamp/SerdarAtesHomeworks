using ApartmentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Business.Abstracts
{
    public interface IMessageService
    {
        List<Message> GetAllMessage();
        void AddMessage(Message message);

        void DeleteMessage(Message message);
    }
}
