using BloodDonation.Domain.Entities;
using BloodDonation.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Infrastructure.Repositories
{
    public class DonationRepository : IDonationRepository
    {
        public Task<int> CreateDonationAsync(Donation donation)
        {
            throw new NotImplementedException();
        }

        public Task<List<Donation>> GetAllByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
