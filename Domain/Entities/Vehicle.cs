using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public partial class Vehicle
    {
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
    }
}
