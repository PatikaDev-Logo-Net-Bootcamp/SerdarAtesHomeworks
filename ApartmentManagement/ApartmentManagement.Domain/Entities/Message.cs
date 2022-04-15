using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Domain.Entities
{
    public class Message:BaseEntity
    {
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public DateTime SendTime { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
    }
}
