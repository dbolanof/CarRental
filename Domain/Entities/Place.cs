using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class Place
    {    

        [Key]
        public int IdPlace { get; set; }
        [StringLength(100)]
        public string Descripcion { get; set; } = null!;
        [StringLength(20)]
        public string? Latitude { get; set; }
        [StringLength(20)]
        public string? Longitude { get; set; }

        [InverseProperty(nameof(Vehicle.IdPlaceDeliveryNavigation))]
        public virtual ICollection<Vehicle> VehicleIdPlaceDeliveryNavigation { get; set; }
        [InverseProperty(nameof(Vehicle.IdPlacePickUpNavigation))]
        public virtual ICollection<Vehicle> VehicleIdPlacePickUpNavigation { get; set; }
    }
}
