using BloodDonation.Domain.Entities.Base;
using BloodDonation.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Domain.Entities
{
    public class BloodStorage : BaseEntity
    {
        public BloodStorage(int id, BloodTypeEnum bloodType, RhFactorEnum rhFactor, int quantityInMililiters)
        {
            Id = id;
            BloodType = bloodType;
            RhFactor = rhFactor;
            QuantityInMililiters = quantityInMililiters;
        }

        public int Id { get; private set; }
        public BloodTypeEnum BloodType { get; private set; }
        public RhFactorEnum RhFactor { get; private set; }
        public int QuantityInMililiters { get; private set; }
    }
}
