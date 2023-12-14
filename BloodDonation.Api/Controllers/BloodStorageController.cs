using BloodDonation.Api.Controllers.Base;
using BloodDonation.Application.Queries.BloodStorage.GetAllBloodStorage;
using BloodDonation.Application.Queries.BloodStorage.GetAllBloodStorageByType;
using BloodDonation.Domain.Enum;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BloodDonation.Api.Controllers
{
    public class BloodStorageController : BaseController
    {
        public BloodStorageController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllBloodStorageQuery();
            var result = await _mediator.Send(query);
            return StatusCode((int)result.StatusCode, result.GetFinalObject());
        }

        [HttpGet("GetByType")]
        public async Task<IActionResult> GetByType(BloodTypeEnum type)
        {
            var query = new GetAllBloodStorageByTypeQuery(type);
            var result = await _mediator.Send(query);
            return StatusCode((int)result.StatusCode, result.GetFinalObject());
        }
    }
}
