using Api.Controllers.Base;
using Application.DTOs.Vehicle;
using Application.Features.Vehicle.Commands;
using Application.Features.Vehicle.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.v1
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    public class VehicleController : BaseController
    {
        [HttpGet("{id}")]   
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VehicleDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(VehicleDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(VehicleDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(VehicleDto))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(VehicleDto))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new GetVehicleByIdQuery() { IdVehicle = id }));
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VehicleDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(VehicleDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(VehicleDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(VehicleDto))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(VehicleDto))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Get([FromQuery] GetAllVehicleQuery filter)
        {
            return Ok(await Mediator.Send(new GetAllVehicleQuery()
            {
                PageNumber = filter.PageNumber,
                PageSize = filter.PageSize,
                Name = filter.Name,
                Description = filter.Description
            }));
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateVehicleCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
        [HttpPut()]
        public async Task<IActionResult> Put(UpdateVehicleCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteVehicleCommand() { IdVehicle = id }));
        }
    }
}
