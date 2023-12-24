using BloodDonation.Domain.Events;
using BloodDonation.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Application.DomainEventHandlers.Donations
{
    public class DonationCreatedEventHandler : INotificationHandler<DonationCreatedEvent>
    {
        private readonly IUnitOfWork _unitOfWork;
        public DonationCreatedEventHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(DonationCreatedEvent notification, CancellationToken cancellationToken)
        {
            await _unitOfWork.BloodStorage.IncreaseQuantityByType(notification.Donation.QuantityInMililiters, notification.Donation.Donor.BloodType);
        }
    }
}
