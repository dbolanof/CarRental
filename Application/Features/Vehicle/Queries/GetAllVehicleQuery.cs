using Application.DTOs.Vehicle;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Vehicle.Queries
{
    public class GetAllVehicleQuery : IRequest<PageResponse<List<VehicleDto>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public short Status { get; set; }
        public int PlacePickUp { get; set; }
        public int PlaceDelivery { get; set; }
    }
}
