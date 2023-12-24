using BloodDonation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodDonation.Domain.Enum;

namespace BloodDonation.Infrastructure.Repositories.Configurations
{
    public class BloodStorageEntityTypeConfiguration : IEntityTypeConfiguration<BloodStorage>
    {
        public void Configure(EntityTypeBuilder<BloodStorage> builder)
        {
            builder.HasIndex(b => b.BloodType);

            builder.HasKey(x => x.Id);
            builder.Property(b => b.BloodType).IsRequired();
            builder.Property(b => b.RhFactor).IsRequired();
            builder.Property(b => b.QuantityInMililiters).IsRequired();

            builder.HasData(
                new BloodStorage(1, BloodTypeEnum.A, RhFactorEnum.Positive, 0),
                new BloodStorage(2, BloodTypeEnum.A, RhFactorEnum.Negative, 0),
                new BloodStorage(3, BloodTypeEnum.B, RhFactorEnum.Positive, 0),
                new BloodStorage(4, BloodTypeEnum.B, RhFactorEnum.Negative, 0),
                new BloodStorage(5, BloodTypeEnum.AB, RhFactorEnum.Positive, 0),
                new BloodStorage(6, BloodTypeEnum.AB, RhFactorEnum.Negative, 0),
                new BloodStorage(7, BloodTypeEnum.O, RhFactorEnum.Positive, 0),
                new BloodStorage(8, BloodTypeEnum.O, RhFactorEnum.Negative, 0)
            );
        }
    }
}
