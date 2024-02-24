using Application.BusinessRules;
using Application.Constants;
using Application.Features.Vehicle.Commands;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using MediatR;
namespace Application.Features.Vehicle.Handlers
{
    public class CreateVehicleCommandHandler : IRequestHandler<CreateVehicleCommand, Response<int>>
    {
        private readonly VehicleRules _business;

        public CreateVehicleCommandHandler(IRepositoryAsync<Domain.Entities.Vehicle> repositoryAsync, IMapper mapper)
        {
            _business = new VehicleRules(mapper, repositoryAsync);

        }
        public async Task<Response<int>> Handle(CreateVehicleCommand request, CancellationToken cancellationToken)
        {
            return new Response<int>(await _business.AddAsync(request), Messages.MsjCreating);
        }
    }
}
