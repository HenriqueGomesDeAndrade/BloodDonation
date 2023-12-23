using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Interfaces;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.Donor.GetDonorDonationsById
{
    public class GetDonorDonationsByIdQueryHandler : IRequestHandler<GetDonorDonationsByIdQuery, Result<DonorViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetDonorDonationsByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<DonorViewModel>> Handle(GetDonorDonationsByIdQuery request, CancellationToken cancellationToken)
        {
            var donor = await _unitOfWork.Donor.GetDonorByIdAsync(request.Id);
            return Result<DonorViewModel>.Success(donor);
        }
    }
}
