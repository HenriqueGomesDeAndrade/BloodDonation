using BloodDonation.Domain.Entities;
using BloodDonation.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Infrastructure.Repositories
{
    internal class DonorRepository : IDonorRepository
    {
        public Task<int> CreateDonorAsync(Donor donor)
        {
            throw new NotImplementedException();
        }

        public Task<List<Donor>> GetAllDonorsAsync(int top, int skip)
        {
            throw new NotImplementedException();
        }

        public Task<Donor> GetDonorByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
