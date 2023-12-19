using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Enum;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Commands.Donor.CreateDonor
{
    public class CreateDonorCommand : IRequest<Result<DonorViewModel>>
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderEnum Gender { get; set; }
        public double Weight { get; set; }
        public BloodTypeEnum BloodType { get; set; }
        public RhFactorEnum RhFactor { get; set; }

        public CreateDonorAddressCommand Address { get; set; }
    }
}
