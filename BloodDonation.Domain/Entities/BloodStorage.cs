using BloodDonation.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Domain.Entities
{
    public class BloodStorage
    {
        public int Id { get; set; }
        public BloodTypeEnum BloodType { get; set; }
        public RhFactorEnum RhFactor { get; set; }
        public int QuantityInMililiters { get; set; }
    }
}
