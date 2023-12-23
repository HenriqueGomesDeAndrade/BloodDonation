using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Commands.Donations.CreateDonation
{
    public class CreateDonationCommand : IRequest<Result<int>>
    {
        public int DonorId { get; set; }
        public DateTime DonationDate { get; set; }
        public int QuantityInMililiters { get; set; }
    }
}
