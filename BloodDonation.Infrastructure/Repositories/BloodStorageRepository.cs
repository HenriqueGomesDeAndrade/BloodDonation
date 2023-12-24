using BloodDonation.Domain.Entities;
using BloodDonation.Domain.Enum;
using BloodDonation.Domain.Interfaces;
using BloodDonation.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Infrastructure.Repositories
{
    public class BloodStorageRepository : BaseRepository, IBloodStorageRepository
    {
        public BloodStorageRepository(BloodDonationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<BloodStorage>> GetAllAsync(int top, int skip)
        {
            return await _dbContext.BloodStorage
                .Skip(skip)
                .Take(top)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<BloodStorage>> GetAllByTypeAsync(int top, int skip, BloodTypeEnum type)
        {
            return await _dbContext.BloodStorage
                .Where(bs => bs.BloodType == type)
                .Skip(skip)
                .Take(top)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task IncreaseQuantityByType(int quantity, BloodTypeEnum type, RhFactorEnum rhFactor)
        {
            var bloodStorage = await _dbContext.BloodStorage.FirstOrDefaultAsync(x => x.BloodType == type && x.RhFactor == rhFactor);
            if (bloodStorage == null)
                return;

            bloodStorage.IncreaseQuantity(quantity);
        }
    }
}
