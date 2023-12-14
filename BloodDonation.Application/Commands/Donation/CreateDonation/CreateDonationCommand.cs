using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Commands.Donation.CreateDonation
{
    public class CreateDonationCommand : IRequest<Result<DonationViewModel>>
    {
    }
}
