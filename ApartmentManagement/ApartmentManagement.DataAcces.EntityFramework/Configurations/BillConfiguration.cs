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
    internal class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasOne<Flats>(b => b.Flat).
            WithMany(u => u.Bills).
            HasForeignKey(b => b.FlatId).
            OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<BillType>(b => b.BillType).
            WithMany(u => u.Bills).
            HasForeignKey(b => b.BillTypeId).
            OnDelete(DeleteBehavior.Cascade);
        }
    }
}
