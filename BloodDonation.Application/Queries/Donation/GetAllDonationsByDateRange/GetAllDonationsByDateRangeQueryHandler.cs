using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Interfaces;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.Donation.GetAllDonationsByDateRange
{
    internal class GetAllDonationsByDateRangeQueryHandler : IRequestHandler<GetAllDonationsByDateRangeQuery, Result<List<DonationViewModel>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllDonationsByDateRangeQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<List<DonationViewModel>>> Handle(GetAllDonationsByDateRangeQuery request, CancellationToken cancellationToken)
        {
            var donationList = await _unitOfWork.Donation.GetAllByDateRangeAsync(request.StartDate, request.EndDate);
            return Result<List<DonationViewModel>>.Success(donationList.Select(d => (DonationViewModel)d).ToList());
        }
    }
}
