using BloodDonation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Domain.Interfaces
{
    public interface IDonationRepository
    {
        Task<List<Donation>> GetAllByLastDaysAsync(int lastDays);
        Task<int> CreateDonationAsync(Donation donation);
    }
}
