using BloodDonation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Infrastructure
{
    public class BloodDonationDbContext : DbContext
    {
        public BloodDonationDbContext(DbContextOptions<BloodDonationDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<Donation> Donation { get; set; }
        public DbSet<Donor> Donor { get; set; }
        public DbSet<BloodStorage> BloodStorage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
