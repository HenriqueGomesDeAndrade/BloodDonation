using BloodDonation.Domain.Entities;
using BloodDonation.Domain.Enum;
using BloodDonation.Domain.ValueObjects;

namespace BloodDonation.Application.ViewModels
{
    public class DonorViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderEnum Gender { get; set; }
        public double Weight { get; set; }
        public BloodTypeEnum BloodType { get; set; }
        public RhFactorEnum RhFactor { get; set; }
        public List<Donation> Donations { get; set; }
        public Address Address { get; set; }

        public static implicit operator DonorViewModel(Donor donor)
        {
            return new()
            {
                Id = donor.Id,
                FullName = donor.FullName,
                Email = donor.Email,
                DateOfBirth = donor.DateOfBirth,
                Gender = donor.Gender,
                Weight = donor.Weight,
                BloodType = donor.BloodType,
                RhFactor = donor.RhFactor,
                Address = donor.Address,
                Donations = donor.Donations,
            };
        }
    }
}
