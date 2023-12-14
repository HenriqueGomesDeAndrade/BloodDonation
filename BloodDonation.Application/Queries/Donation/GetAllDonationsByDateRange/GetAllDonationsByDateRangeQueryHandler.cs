using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.Donation.GetAllDonationsByDateRange
{
    internal class GetAllDonationsByDateRangeQueryHandler : IRequestHandler<GetAllDonationsByDateRangeQuery, Result<List<DonationViewModel>>>
    {
        public Task<Result<List<DonationViewModel>>> Handle(GetAllDonationsByDateRangeQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
