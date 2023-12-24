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
    public class BloodStorageEntityTypeConfiguration : IEntityTypeConfiguration<BloodStorage>
    {
        public void Configure(EntityTypeBuilder<BloodStorage> builder)
        {
            builder.HasAlternateKey(b => b.BloodType);

            builder.HasKey(x => x.Id);
            builder.Property(b => b.BloodType).IsRequired();
            builder.Property(b => b.RhFactor).IsRequired();
            builder.Property(b => b.QuantityInMililiters).IsRequired();
        }
    }
}
