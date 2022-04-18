using ApartmentManagement.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNumber { get; set; }
        public string CarPlateNumber { get; set; }

        public List<Flats> Flats { get; set; }

        public virtual ICollection<Message> ChatMessagesFromUsers { get; set; }
        public virtual ICollection<Message> ChatMessagesToUsers { get; set; }
        public ApplicationUser()
        {
            ChatMessagesFromUsers = new HashSet<Message>();
            ChatMessagesToUsers = new HashSet<Message>();
        }
    }
}
