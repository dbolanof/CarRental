using Domain.Entities;

namespace Domain.Extended
{
    public partial class Vehicle
    {
        public virtual Vehicle IdPlaceDelivery { get; set; }
        public virtual Vehicle IdPlacePickUp { get; set; }
        public virtual StatusVehicle IdStatusVehicle { get; set; }
    }
}
