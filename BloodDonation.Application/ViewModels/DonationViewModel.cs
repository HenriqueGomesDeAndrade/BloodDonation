using BloodDonation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Application.ViewModels
{
    public class DonationViewModel
    {
        public int Id { get; set; }
        public int DonorId { get; set; }
        public DateTime DonationDate { get; set; }
        public int QuantityInMililiters { get; set; }

        public static implicit operator DonationViewModel(Donation donation)
        {
            return new()
            {
                Id = donation.Id,
                DonorId = donation.DonorId,
                DonationDate = donation.DonationDate,
                QuantityInMililiters = donation.QuantityInMililiters
            };
        }
    }
}
