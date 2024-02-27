using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class StatusVehicle
    {

        [Key]
        public short IdStatusVehicle { get; set; }
        [StringLength(5)]
        public string Code { get; set; } = null!;
        [StringLength(20)]
        public string Description { get; set; } = null!;

        [InverseProperty("IdStatusVehicleNavigation")]
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
