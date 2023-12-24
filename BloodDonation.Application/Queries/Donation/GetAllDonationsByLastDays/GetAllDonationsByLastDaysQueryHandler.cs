using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Interfaces;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.Donation.GetAllDonationsByDateRange
{
    internal class GetAllDonationsByLastDaysQueryHandler : IRequestHandler<GetAllDonationsByLastDaysQuery, Result<List<DonationViewModel>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllDonationsByLastDaysQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<List<DonationViewModel>>> Handle(GetAllDonationsByLastDaysQuery request, CancellationToken cancellationToken)
        {
            var donationList = await _unitOfWork.Donation.GetAllByLastDaysAsync(request.LastDays);
            return Result<List<DonationViewModel>>.Success(donationList.Select(d => (DonationViewModel)d).ToList());
        }
    }
}
