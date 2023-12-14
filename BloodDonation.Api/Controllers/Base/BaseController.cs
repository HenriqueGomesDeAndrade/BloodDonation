using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BloodDonation.Api.Controllers.Base
{
    [ApiController]
    [Route("api")]
    public class BaseController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
