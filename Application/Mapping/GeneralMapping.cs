using Application.DTOs.Vehicle;
using Application.Features.Vehicle.Commands;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            #region Querys            
            CreateMap<Vehicle, VehicleDto>().ReverseMap();
            CreateMap<Vehicle, CreateVehicleCommand>().ReverseMap();
            #endregion
            #region Commands
            CreateMap<CreateVehicleCommand, Vehicle>().ReverseMap();
            CreateMap<UpdateVehicleCommand, Vehicle>().ReverseMap();
            #endregion

            #region Test Integrations
            #region Vehicle
            CreateMap<CreateVehicleCommand, VehicleDto>().ReverseMap();
            #endregion
            #endregion
        }
    }
}
