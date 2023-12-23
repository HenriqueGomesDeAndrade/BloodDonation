using BloodDonation.Api.Controllers.Base;
using BloodDonation.Application.Queries.BloodStorage.GetAllBloodStorage;
using BloodDonation.Application.Queries.BloodStorage.GetAllBloodStorageByType;
using BloodDonation.Domain.Enum;
using BloodDonation.Domain.Helpers;
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
        public async Task<IActionResult> Get([FromQuery] PageQuery pageQuery)
        {
            var query = new GetAllBloodStorageQuery(pageQuery);
            var result = await _mediator.Send(query);
            return StatusCode((int)result.StatusCode, result.GetFinalObject());
        }

        [HttpGet("GetByType")]
        public async Task<IActionResult> GetByType([FromQuery] PageQuery pageQuery, BloodTypeEnum type)
        {
            var query = new GetAllBloodStorageByTypeQuery(type, pageQuery);
            var result = await _mediator.Send(query);
            return StatusCode((int)result.StatusCode, result.GetFinalObject());
        }
    }
}
