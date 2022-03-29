using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkfour.Business.DTOs
{
    public class CompanyDeleteUpdateDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string createdBy { get; set; }
        public DateTime createdAt { get; set; }
    }
}
