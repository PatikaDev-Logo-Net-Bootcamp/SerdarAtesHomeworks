using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Business.DTOs
{
    public class BillDto
    {
        public int Id { get; set; }
        public string FlatNumber { get; set; }
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string BillTypeName { get; set; }
        public DateTime BillDate { get; set; }
        public bool IsActive { get; set; }
        public decimal Price { get; set; }
    }
}
