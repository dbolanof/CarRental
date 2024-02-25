using Application.Constants;
using Application.DTOs.Vehicle;
using Application.Features.Vehicle.Commands;
using Application.Features.Vehicle.Queries;
using Application.Interfaces;
using Application.Specifications;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessRules
{
    public class VehicleRules : RulesConfigure<Vehicle>
    {
        private readonly IRepositoryAsync<Vehicle> _repositoryAsync;
        private readonly IMapper _mapper;
        public VehicleRules(IMapper mapper, IRepositoryAsync<Vehicle> repositoryAsync)
        {
            _mapper = mapper;
            _repositoryAsync = repositoryAsync;
        }
        public async Task<VehicleDto> GetByIdAsync(GetVehicleByIdQuery request)
        {
            Vehicle vehicle = await _repositoryAsync.GetByIdAsync(request.IdVehicle);
            return vehicle == null
                ? throw new KeyNotFoundException(String.Format(Messages.NotFound, request.IdVehicle))
                : _mapper.Map<VehicleDto>(vehicle);
        }
        public async Task<bool> ValidateDuplicate(ValidateDuplicated request, int id = 0)
        {

            List<Vehicle> vehicle = await _repositoryAsync.ListAsync(new SearchPlateNumber(request.PlateNumbe) { });
            if ((id > 0 && vehicle.FindAll(s => !s.IdVehicle.Equals(id)).Count > 0) || (vehicle.Count > 0 && id == 0))
            {
                throw new Exceptions.ApiException(String.Format(Messages.RecordExist, request.PlateNumbe));
            }
            return false;
        }
        public async Task<PageResponse<List<VehicleDto>>> GetAllAsync(GetAllVehicleQuery request)
        {
            List<Vehicle> vehicle = await _repositoryAsync.ListAsync(new PagedVehicleSpecification(request.PageSize, request.PageNumber, request.Status, request.PlaceDelivery,request.PlacePickUp) { });
            List<VehicleDto> VehicleDto = _mapper.Map<List<VehicleDto>>(vehicle);
            return new PageResponse<List<VehicleDto>>(VehicleDto, request.PageNumber, request.PageSize);
        }
        public async Task<int> AddAsync(CreateVehicleCommand request)
        {
            await ValidateDuplicate(new ValidateDuplicated() { PlateNumbe = request.PlateNumbe }, 0);
            var objSend = _mapper.Map<Vehicle>(request);
            return (await _repositoryAsync.AddAsync(objSend)).IdVehicle;
        }
    }
}
