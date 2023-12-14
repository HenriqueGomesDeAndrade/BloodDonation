using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Commands.Donation.CreateDonation
{
    public class CreateDonationCommandHandler : IRequestHandler<CreateDonationCommand, Result<DonationViewModel>>
    {
        public Task<Result<DonationViewModel>> Handle(CreateDonationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
