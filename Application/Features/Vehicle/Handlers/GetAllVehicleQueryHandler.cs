using Application.BusinessRules;
using Application.DTOs.Vehicle;
using Application.Features.Vehicle.Queries;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using MediatR;

namespace Application.Features.Vehicle.Handlers
{
    public class GetAllVehicleQueryHandler : IRequestHandler<GetAllVehicleQuery, PageResponse<List<VehicleDto>>>
    {
        private readonly VehicleRules buissnes;
        public GetAllVehicleQueryHandler(IMapper mapper, IRepositoryAsync<Domain.Entities.Vehicle> repositoryAsync)
        {
            buissnes = new VehicleRules(mapper, repositoryAsync);
        }
        public async Task<PageResponse<List<VehicleDto>>> Handle(GetAllVehicleQuery request, CancellationToken cancellationToken)
        {
            return await buissnes.GetAllAsync(request);
        }
    }
}
