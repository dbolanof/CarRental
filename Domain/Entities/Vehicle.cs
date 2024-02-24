using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class Vehicle
    {
        [Key]
        public int IdVehicle { get; set; }
        [StringLength(10)]
        public string PlateNumbe { get; set; }
        [StringLength(20)]
        public string Brand { get; set; }
        [Required]
        [StringLength(5)]
        public string Model { get; set; }
        [Required]
        [StringLength(20)]
        public string Color { get; set; }
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
