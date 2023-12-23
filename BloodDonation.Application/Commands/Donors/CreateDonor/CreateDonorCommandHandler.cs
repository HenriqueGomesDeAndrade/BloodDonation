using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Entities;
using BloodDonation.Domain.Interfaces;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Commands.Donors.CreateDonor
{
    public class CreateDonorCommandHandler : IRequestHandler<CreateDonorCommand, Result<int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateDonorCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<int>> Handle(CreateDonorCommand request, CancellationToken cancellationToken)
        {
            Donor donor = new(0, request.FullName, request.Email, request.DateOfBirth, request.Gender, request.Weight, request.BloodType, request.RhFactor, request.Address);

            await _unitOfWork.BeginTransactionAsync();
            await _unitOfWork.Donor.CreateDonorAsync(donor);
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitAsync();

            return Result<int>.Success(donor.Id);
        }
    }
}
