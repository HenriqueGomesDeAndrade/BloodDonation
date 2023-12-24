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
    public class DonationEntityTypeConfiguration : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasOne(d => d.Donor)
                .WithMany(d => d.Donations)
                .HasForeignKey(d => d.DonorId);

            builder.HasIndex(d => d.DonationDate);

            builder.Property(d => d.DonorId).IsRequired();
            builder.Property(d => d.DonationDate).IsRequired();
            builder.Property(d => d.QuantityInMililiters).IsRequired();
        }
    }
}
