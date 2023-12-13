using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Commands.Donor.CreateDonor
{
    public class CreateDonorCommandHandler : IRequestHandler<CreateDonorCommand, Result<DonorViewModel>>
    {
        public Task<Result<DonorViewModel>> Handle(CreateDonorCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
