using BloodDonation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Domain.Interfaces
{
    public interface IDonorRepository
    {
        Task<List<Donor>> GetAllDonorsAsync(int top, int skip);
        Task<Donor> GetDonorByIdAsync(int id);
        Task<int> CreateDonorAsync(Donor donor);
    }
}
