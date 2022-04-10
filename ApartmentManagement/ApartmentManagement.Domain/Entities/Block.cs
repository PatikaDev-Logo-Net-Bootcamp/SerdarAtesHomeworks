using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Domain.Entities
{
    public class Block:BaseEntity
    {
        public string BlockName { get; set; }
        public byte MaxFlat { get; set; }

        public List<Flats> Flats { get; set; }
    }
}
