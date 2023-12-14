using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.Donor.GetDonorDonationsById
{
    public class GetDonorDonationsByIdQueryHandler : IRequestHandler<GetDonorDonationsByIdQuery, Result<DonorViewModel>>
    {
        public Task<Result<DonorViewModel>> Handle(GetDonorDonationsByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
