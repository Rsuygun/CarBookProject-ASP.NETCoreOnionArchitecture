using CarBook.Application.Features.Mediator.Commands.LocaitonCommands;
using CarBook.Application.Features.Mediator.Queries.LocaitonQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LocationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> LocationList()
        {
            var values = await _mediator.Send(new GetLocationQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLocation(int id)
        {
            var values = await _mediator.Send(new GetLocaitonByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLocation(CreateLocaitonCommand command)
        {
            await _mediator.Send(command);
            return Ok("Konum Bilgisi Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveLocation(int id)
        {
            await _mediator.Send(new RemoveLocaitonCommand(id));
            return Ok("Konum Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateLocation(UpdateLocaitonCommand command)
        {
            await _mediator.Send(command);
            return Ok("Konum Bilgisi Güncellendi");
        }
    }
}
