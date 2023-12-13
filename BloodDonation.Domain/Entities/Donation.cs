using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Domain.Entities
{
    public class Donation
    {
        public int Id { get; set; }
        public int DonorId { get; set; }
        public DateTime DonationDate { get; set; }
        public int QuantityInMililiters { get; set; }
        public Donor Donor { get; set; }
    }
}
