using BloodDonation.Api.Controllers.Base;
using BloodDonation.Application.Commands.Donations.CreateDonation;
using BloodDonation.Application.Queries.Donation.GetAllDonationsByDateRange;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BloodDonation.Api.Controllers
{
    public class DonationController : BaseController
    {
        public DonationController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateDonationCommand command)
        {
            var result = await _mediator.Send(command);
            return StatusCode((int)result.StatusCode, result.GetFinalObject());
        }

        [HttpGet("GetAllByLastDays")]
        public async Task<IActionResult> GetByDateRange([FromQuery]GetAllDonationsByLastDaysQuery query)
        {
            var result = await _mediator.Send(query);
            return StatusCode((int)result.StatusCode, result.GetFinalObject());
        }
    }
}
