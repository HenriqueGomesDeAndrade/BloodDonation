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
    public class DonationRepository : BaseRepository, IDonationRepository
    {
        public DonationRepository(BloodDonationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<int> CreateDonationAsync(Donation donation)
        {
            await _dbContext.Donation.AddAsync(donation);
            return donation.Id;
        }

        public async Task<List<Donation>> GetAllByLastDaysAsync(int lastDays)
        {
            var dateToCompare = DateTime.UtcNow.AddDays(-lastDays);
            return await _dbContext.Donation
                .Where(x => x.DonationDate > dateToCompare)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
