using BloodDonation.Api.Controllers.Base;
using BloodDonation.Application.Commands.Donor.CreateDonor;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BloodDonation.Api.Controllers
{
    public class DonorController : BaseController
    {
        private readonly IMediator _mediator;
        public DonorController(
            IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateDonorCommand command)
        {
            var result = await _mediator.Send(command);
            return StatusCode((int)result.StatusCode, result.GetFinalObject());
        }

    }
}
