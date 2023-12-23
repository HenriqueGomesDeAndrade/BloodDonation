using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IDonorRepository Donor { get; }
        IDonationRepository Donation {  get; }
        IBloodStorageRepository BloodStorage { get; }

        Task BeginTransactionAsync();
        Task CommitAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
