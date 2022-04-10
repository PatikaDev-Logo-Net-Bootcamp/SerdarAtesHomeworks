using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Domain.Entities
{
    public class BillType : BaseEntity
    {
        public string BillTypeName { get; set; }

        public List<Bill> Bills { get; set; }
    }
}
