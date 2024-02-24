using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class Place
    {

        public Place()
        {
            VehicleIdPlaceDeliveryNavigation = new HashSet<Vehicle>();
            VehicleIdPlacePickUpNavigation = new HashSet<Vehicle>();
        }

        [Key]
        public int IdPlace { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [StringLength(20)]
        public string Latitude { get; set; }
        [StringLength(20)]
        public string Longitude { get; set; }

        [InverseProperty(nameof(Vehicle.IdPlaceDeliveryNavigation))]
        public virtual ICollection<Vehicle> VehicleIdPlaceDeliveryNavigation { get; set; }
        [InverseProperty(nameof(Vehicle.IdPlacePickUpNavigation))]
        public virtual ICollection<Vehicle> VehicleIdPlacePickUpNavigation { get; set; }
    }
}
