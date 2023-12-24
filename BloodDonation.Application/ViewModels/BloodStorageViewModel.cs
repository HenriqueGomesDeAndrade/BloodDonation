using BloodDonation.Domain.Entities;
using BloodDonation.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Application.ViewModels
{
    public class BloodStorageViewModel
    {
        public int Id { get; set; }
        public BloodTypeEnum BloodType { get; set; }
        public RhFactorEnum RhFactor { get; set; }
        public int QuantityInMililiters { get; set; }


        public static implicit operator BloodStorageViewModel(BloodStorage bloodStorage)
        {
            if (bloodStorage == null) 
                return null;
            return new BloodStorageViewModel 
            {
                Id = bloodStorage.Id,
                BloodType = bloodStorage.BloodType,
                RhFactor = bloodStorage.RhFactor,
                QuantityInMililiters = bloodStorage.QuantityInMililiters
            };
        }
    }
}
