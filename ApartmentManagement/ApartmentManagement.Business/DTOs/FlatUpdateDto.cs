using ApartmentManagement.Domain;
using ApartmentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Business.DTOs
{
    public class FlatUpdateDto
    {
        public int Id { get; set; }
        public int BlockId { get; set; }
        public IEnumerable<Block> Blocks { get; set; }
        public bool IsEmpty { get; set; }
        public string Type { get; set; }
        public string Floor { get; set; }
        public string FlatNo { get; set; }
        public string OwnerId { get; set; }
        public IEnumerable<ApplicationUser> Owner { get; set; }
    }
}
