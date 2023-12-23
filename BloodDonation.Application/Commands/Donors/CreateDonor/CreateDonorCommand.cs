using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Enum;
using BloodDonation.Domain.Result;
using BloodDonation.Domain.ValueObjects;
using MediatR;

namespace BloodDonation.Application.Commands.Donors.CreateDonor
{
    public class CreateDonorCommand : IRequest<Result<int>>
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderEnum Gender { get; set; }
        public double Weight { get; set; }
        public BloodTypeEnum BloodType { get; set; }
        public RhFactorEnum RhFactor { get; set; }

        public Address Address { get; set; }
    }
}
