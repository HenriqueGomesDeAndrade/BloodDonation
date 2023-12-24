using BloodDonation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Infrastructure.Repositories.Configurations
{
    public class DonorEntityTypeConfiguration : IEntityTypeConfiguration<Donor>
    {
        public void Configure(EntityTypeBuilder<Donor> builder)
        {
            builder.HasIndex(d => d.Email).IsUnique();

            builder.Property(d => d.FullName).IsRequired();
            builder.Property(d => d.Email).IsRequired();
            builder.Property(d => d.DateOfBirth).IsRequired();
            builder.Property(d => d.Gender).IsRequired();
            builder.Property(d => d.Weight).IsRequired();
            builder.Property(d => d.BloodType).IsRequired();
            builder.Property(d => d.RhFactor).IsRequired();
            builder.Property(d => d.Address).IsRequired();

        }
    }
}
