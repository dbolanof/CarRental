using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class StatusVehicle
    {

        public StatusVehicle()
        {
            Vehicle = new HashSet<Vehicle>();
        }

        [Key]
        public short IdStatusVehicle { get; set; }
        [Required]
        [StringLength(5)]
        public string Code { get; set; }
        [Required]
        [StringLength(20)]
        public string Description { get; set; }

        [InverseProperty("IdStatusVehicleNavigation")]
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
