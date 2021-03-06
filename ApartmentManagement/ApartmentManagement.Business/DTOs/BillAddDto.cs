using ApartmentManagement.Domain;
using ApartmentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Business.DTOs
{
    public class BillAddDto
    {
   
        public string FlatNumber { get; set; }
        public string FullName { get; set; }
        public int FlatId { get; set; }
        public IEnumerable<Flats> Flat{ get; set; }
        public int BillTypeId { get; set; }
        public IEnumerable<BillType> BillType { get; set; }
        public DateTime BillDate { get; set; }
        public decimal Price { get; set; }
    }
}
