using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Domain.Entities
{
    public class Message:BaseEntity
    {
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string content { get; set; }
        public bool IsRead { get; set; }
    }
}
