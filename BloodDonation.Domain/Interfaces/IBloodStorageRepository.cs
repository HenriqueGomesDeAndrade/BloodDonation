using BloodDonation.Domain.Entities;
using BloodDonation.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Domain.Interfaces
{
    public interface IBloodStorageRepository
    {
        Task<List<BloodStorage>> GetAllAsync(int top, int skip);
        Task<List<BloodStorage>> GetAllByTypeAsync(int top, int skip, BloodTypeEnum type);
        Task IncreaseQuantityByType(int quantity, BloodTypeEnum type, RhFactorEnum rhFactor);
    }
}
