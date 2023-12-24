using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Result;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace BloodDonation.Application.Queries.Donation.GetAllDonationsByDateRange
{
    public class GetAllDonationsByLastDaysQuery : IRequest<Result<List<DonationViewModel>>>
    {
        [Required]
        public int LastDays { get; set; }
    }
}
