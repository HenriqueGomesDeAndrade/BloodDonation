using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Domain.Entities
{
    public class Donation
    {
        public Donation(int id, int donorId, DateTime donationDate, int quantityInMililiters)
        {
            Id = id;
            DonorId = donorId;
            DonationDate = donationDate;
            QuantityInMililiters = quantityInMililiters;
        }

        public int Id { get; private set; }
        public int DonorId { get; private set; }
        public DateTime DonationDate { get; private set; }
        public int QuantityInMililiters { get; private set; }
        public Donor Donor { get; private set; }
    }
}
