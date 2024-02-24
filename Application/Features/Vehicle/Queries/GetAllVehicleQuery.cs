using Application.DTOs.Vehicle;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Vehicle.Queries
{
    public class GetAllVehicleQuery : IRequest<PageResponse<List<VehicleDto>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
