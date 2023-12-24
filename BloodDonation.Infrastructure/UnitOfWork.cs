using BloodDonation.Domain.Interfaces;
using BloodDonation.Infrastructure.Extensions;
using MediatR;
using Microsoft.EntityFrameworkCore.Storage;

namespace BloodDonation.Infrastructure
{
    internal class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly BloodDonationDbContext _dbContext;
        private IDbContextTransaction _dbTransaction;
        private readonly IMediator _mediator;

        public UnitOfWork(
            BloodDonationDbContext dbContext,
            IDonorRepository donorRepository,
            IDonationRepository donationRepository,
            IBloodStorageRepository bloodStorageRepository,
            IMediator mediator)
        {
            _dbContext = dbContext;
            Donor = donorRepository;
            Donation = donationRepository;
            BloodStorage = bloodStorageRepository;
            _mediator = mediator;
        }

        public IDonorRepository Donor { get; }
        public IDonationRepository Donation { get; }
        public IBloodStorageRepository BloodStorage { get; }

        public async Task BeginTransactionAsync()
        {
            _dbTransaction = await _dbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            try
            {
                await _dbTransaction.CommitAsync();

            }
            catch (Exception)
            {
                await _dbTransaction.RollbackAsync();
                throw;
            }
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _mediator.DispatchDomainEventsAsync(_dbContext);
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
