using BloodDonation.Domain.Entities.Base;
using BloodDonation.Domain.Enum;
using BloodDonation.Domain.ValueObjects;

namespace BloodDonation.Domain.Entities
{
    public class Donor : BaseEntity
    {
        public Donor(int id, string fullName, string email, DateTime dateOfBirth, GenderEnum gender, double weight, BloodTypeEnum bloodType, RhFactorEnum rhFactor, Address address)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Weight = weight;
            BloodType = bloodType;
            RhFactor = rhFactor;
            Address = address;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public GenderEnum Gender { get; private set; }
        public double Weight { get; private set; }
        public BloodTypeEnum BloodType { get; private set; }
        public RhFactorEnum RhFactor { get; private set; }
        public List<Donation> Donations { get; private set; }
        public Address Address { get; private set; }

        public bool IsUnderaged()
        {
            DateTime dateToNotBeUnderaged  = DateTime.UtcNow.AddYears(-18);

            return DateOfBirth > dateToNotBeUnderaged;
        }

        public bool IsLastDonationRangeValid()
        {
            DateTime? lastDonationDate = Donations.OrderBy(d => d.DonationDate).FirstOrDefault()?.DonationDate;
            if (lastDonationDate == null)
                return true;

            int rangeComparer = Gender switch
            {
                GenderEnum.Male => 90,
                GenderEnum.Female => 60,
                _ => throw new InvalidOperationException("Invalid Enum")
            };

            DateTime dateBasedOnComparer = DateTime.UtcNow.AddDays(-rangeComparer);
            return lastDonationDate < dateBasedOnComparer;
        }
        
    }
}
