using BloodDonation.Application.Errors;
using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Entities;
using BloodDonation.Domain.Interfaces;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Commands.Donations.CreateDonation
{
    public class CreateDonationCommandHandler : IRequestHandler<CreateDonationCommand, Result<int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateDonationCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<int>> Handle(CreateDonationCommand request, CancellationToken cancellationToken)
        {
            Donation donation = new(0, request.DonorId, request.DonationDate, request.QuantityInMililiters);

            Donor donor = await _unitOfWork.Donor.GetDonorByIdAsync(donation.DonorId);
            if (donor is null)
                return Result<int>.Failure(DonationError.NotFoundDonor, ResultStatusCodeEnum.NotFound);

            if (donor.IsUnderaged())
                return Result<int>.Failure(DonationError.UnderagedDonor, ResultStatusCodeEnum.Forbidden);

            if(!donor.IsLastDonationRangeValid())
                return Result<int>.Failure(DonationError.InvalidLastDonationDaysRange, ResultStatusCodeEnum.Forbidden);

            await _unitOfWork.BeginTransactionAsync();
            await _unitOfWork.Donation.CreateDonationAsync(donation);
            await _unitOfWork.BloodStorage.UpdateFromDonation(donation);
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitAsync();

            return Result<int>.Success(donation.Id);
        }
    }
}
