using Application.DTOs.Place;
using Application.DTOs.StatusVehicle;

namespace Application.DTOs.Vehicle
{
    public record VehicleDto
    {
        public int IdVehicle { get; set; }
        public string PlateNumbe { get; set; } = null!;
        public string Brand { get; set; }
        public string Model { get; set; } = null!;
        public string Color { get; set; } = null!;
        public short IdStatusVehicle { get; set; }
        public int IdPlacePickUp { get; set; }
        public int IdPlaceDelivery { get; set; }
        public StatusVehicleDto StatusVehicleNavigation { get; set; }
        public PlaceDto IdPlacePickUpNavigation { get; set; }
        public PlaceDto IdPlaceDeliveryNavigation { get; set; }
    }
}
