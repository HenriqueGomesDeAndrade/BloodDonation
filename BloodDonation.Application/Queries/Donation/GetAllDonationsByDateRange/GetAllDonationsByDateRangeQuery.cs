using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.Donation.GetAllDonationsByDateRange
{
    public class GetAllDonationsByDateRangeQuery : IRequest<Result<List<DonationViewModel>>>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
