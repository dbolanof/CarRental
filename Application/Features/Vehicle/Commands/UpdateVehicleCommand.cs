using Application.Wrappers;
using MediatR;

namespace Application.Features.Vehicle.Commands
{
    public class UpdateVehicleCommand : IRequest<Response<int>>
    {
    }
}
