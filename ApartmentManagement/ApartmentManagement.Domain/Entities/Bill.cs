using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Domain.Entities
{
    public class Bill:BaseEntity
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public decimal Price { get; set; }
        public int FlatId { get; set; }
        public Flats Flat { get; set; }
        public DateTime BillDate { get; set; }
        public int BillTypeId { get; set; }
        public BillType BillType { get; set; }

    }
}
