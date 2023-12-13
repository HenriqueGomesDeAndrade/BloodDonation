using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string PublicArea { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public Donor Donor { get; set; }
    }
}
