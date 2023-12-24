using BloodDonation.Domain.Entities.Base;
using BloodDonation.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Domain.Entities
{
    public class Donation : BaseEntity
    {
        public Donation() {}
        public Donation(int id, int donorId, DateTime donationDate, int quantityInMililiters)
        {
            Id = id;
            DonorId = donorId;
            DonationDate = donationDate;
            QuantityInMililiters = quantityInMililiters;

            AddDomainEvent(new DonationCreatedEvent(this));
        }

        public int Id { get; private set; }
        public int DonorId { get; private set; }
        public DateTime DonationDate { get; private set; }
        public int QuantityInMililiters { get; private set; }
        public Donor Donor { get; private set; }
    }
}
