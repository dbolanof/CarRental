using Application.Wrappers;
using MediatR;

namespace Application.Features.Vehicle.Commands
{
    public class CreateVehicleCommand : IRequest<Response<int>>
    {
        public string PlateNumbe { get; set; } = null!;
        public string? Brand { get; set; }
        public string Model { get; set; } = null!;
        public string Color { get; set; } = null!;
        public short? IdStatusVehicle { get; set; }
        public int? IdPlacePickUp { get; set; }
        public int? IdPlaceDelivery { get; set; }
    }
}
