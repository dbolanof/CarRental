using Application.DTOs.Vehicle;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Vehicle.Queries
{
    public class GetVehicleByIdQuery : IRequest<Response<VehicleDto>>
    {
        public int IdVehicle { get; set; }
    }
}
