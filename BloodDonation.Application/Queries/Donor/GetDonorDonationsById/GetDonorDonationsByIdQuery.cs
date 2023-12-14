using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.Donor.GetDonorDonationsById
{
    public class GetDonorDonationsByIdQuery : IRequest<Result<DonorViewModel>>
    {
        public GetDonorDonationsByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
