using ApartmentManagement.Domain;
using ApartmentManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.DataAcces.EntityFramework.Configurations
{
    public class FlatConfiguration : IEntityTypeConfiguration<Flats>
    {
        public void Configure(EntityTypeBuilder<Flats> builder)
        {
            builder.HasOne<ApplicationUser>(x=>x.Owner).
                WithMany(y => y.Flats).
                HasForeignKey(x=>x.OwnerId).
                OnDelete(DeleteBehavior.Cascade);


            builder.HasOne<Block>(x=>x.Blocks).
                WithMany(y=>y.Flats).
                HasForeignKey(x=>x.BlockId).
                OnDelete(DeleteBehavior.Cascade);
          
        }
    }
}
