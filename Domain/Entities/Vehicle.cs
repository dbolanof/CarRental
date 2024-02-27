using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            
        }
        [Key]
        public int IdVehicle { get; set; }
        [StringLength(6)]
        public string PlateNumbe { get; set; } = null!;
        [StringLength(20)]
        public string? Brand { get; set; }
        [StringLength(5)]
        public string Model { get; set; } = null!;
        [StringLength(20)]
        public string Color { get; set; } = null!;
        public short? IdStatusVehicle { get; set; }
        public int? IdPlacePickUp { get; set; }
        public int? IdPlaceDelivery { get; set; }

        [ForeignKey(nameof(IdPlaceDelivery))]
        [InverseProperty(nameof(Place.VehicleIdPlaceDeliveryNavigation))]
        public virtual Place IdPlaceDeliveryNavigation { get; set; }
        [ForeignKey(nameof(IdPlacePickUp))]
        [InverseProperty(nameof(Place.VehicleIdPlacePickUpNavigation))]
        public virtual Place IdPlacePickUpNavigation { get; set; }
        [ForeignKey(nameof(IdStatusVehicle))]
        [InverseProperty(nameof(StatusVehicle.Vehicle))]
        public virtual StatusVehicle IdStatusVehicleNavigation { get; set; }
    }
}
