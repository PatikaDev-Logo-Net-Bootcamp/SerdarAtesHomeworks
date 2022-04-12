using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Business.DTOs
{
    public class FlatDto
    {
        public int Id { get; set; }
        public string BlockName { get; set; }
        public string Floor { get; set; }
        public string FlatNumber { get; set; }
        public string FlatType { get; set; }
        public bool IsEmpty { get; set; }
        public string FullName { get; set; }
    }
}
