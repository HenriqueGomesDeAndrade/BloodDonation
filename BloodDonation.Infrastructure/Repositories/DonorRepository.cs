using BloodDonation.Domain.Entities;
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
    internal class DonorRepository : BaseRepository, IDonorRepository
    {
        public DonorRepository(BloodDonationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<int> CreateDonorAsync(Donor donor)
        {
            await _dbContext.Donor.AddAsync(donor);
            return donor.Id;
        }

        public async Task<List<Donor>> GetAllDonorsAsync(int top, int skip)
        {
            return await _dbContext.Donor
                .Skip(skip)
                .Take(top)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Donor> GetDonorByIdAsync(int id)
        {
            return await _dbContext.Donor
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
