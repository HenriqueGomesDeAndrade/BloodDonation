using BloodDonation.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Domain.Events
{
    public record DonationCreatedEvent(Donation Donation) : INotification;
}
