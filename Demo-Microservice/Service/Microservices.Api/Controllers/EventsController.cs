using MediatR;
using Microservices.Application.Features.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public EventsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult>  GetEventDetails(int id)
        {
            var eventDetails = await _mediator.Send(new GetEventDetailsQuery(id));
            return Ok(eventDetails);
        }
    }
}
        