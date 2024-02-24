using Application.Wrappers;
using MediatR;

namespace Application.Features.Vehicle.Commands
{
    public class DeleteVehicleCommand : IRequest<Response<int>>
    {
        public int IdVehicle { get; set; }
    }
}
