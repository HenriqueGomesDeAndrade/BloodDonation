using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.Donor.GetAllDonors
{
    public class GetAllDonorsQuery : IRequest<Result<List<DonorViewModel>>>
    {
    }
}
