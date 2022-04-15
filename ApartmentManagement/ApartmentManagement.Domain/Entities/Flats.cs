using ApartmentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Domain
{
    public class Flats : BaseEntity
    {
        public int BlockId { get; set; }
        public Block Blocks { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsOwner { get; set; }
        public string Type { get; set; }
        public string Floor { get; set; }
        public string FlatNo { get; set; }
        public string OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }
        public List<Bill> Bills { get; set; }
    }
}
