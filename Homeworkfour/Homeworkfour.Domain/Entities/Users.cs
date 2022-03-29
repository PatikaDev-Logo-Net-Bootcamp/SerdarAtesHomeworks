using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkfour.Domain.Entities
{
    public class Users : BaseEntity
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
