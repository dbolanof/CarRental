using Application.DTOs.Place;
using Application.DTOs.StatusVehicle;
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
            CreateMap<Place, PlaceDto>().ReverseMap();
            CreateMap<StatusVehicle, StatusVehicleDto>().ReverseMap();
            CreateMap<Vehicle, VehicleDto>()
                .ForMember(y => y.IdPlacePickUpNavigation, xy => xy.MapFrom(my => my.IdPlacePickUpNavigation))
                .ForMember(x => x.StatusVehicleNavigation, y => y.MapFrom(m => m.IdStatusVehicleNavigation))
                .ForMember(x => x.IdPlaceDeliveryNavigation, y => y.MapFrom(m => m.IdPlaceDeliveryNavigation)).ReverseMap();



            CreateMap<Vehicle, CreateVehicleCommand>().ReverseMap();

            CreateMap<StatusVehicle, StatusVehicleDto>().ReverseMap();
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
