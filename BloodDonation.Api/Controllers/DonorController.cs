using BloodDonation.Api.Controllers.Base;
using BloodDonation.Application.Commands.Donors.CreateDonor;
using BloodDonation.Application.Queries.Donor.GetAllDonors;
using BloodDonation.Application.Queries.Donor.GetDonorDonationsById;
using BloodDonation.Domain.Helpers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BloodDonation.Api.Controllers
{
    public class DonorController : BaseController
    {
        public DonorController(IMediator mediator)
            : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PageQuery pageQuery)
        {
            var query = new GetAllDonorsQuery(pageQuery);
            var result = await _mediator.Send(query);
            return StatusCode((int)result.StatusCode, result.GetFinalObject());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetDonorDonationsByIdQuery(id);
            var result = await _mediator.Send(query);
            return StatusCode((int)result.StatusCode, result.GetFinalObject());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateDonorCommand command)
        {
            var result = await _mediator.Send(command);
            return StatusCode((int)result.StatusCode, result.GetFinalObject());
        }

    }
}
