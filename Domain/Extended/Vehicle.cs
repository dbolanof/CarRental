namespace Domain.Extended
{
    public partial class Vehicle
    {
        public virtual Vehicle VehicleIdPlaceDeliveryNavigation { get; set; }
        public virtual Vehicle VehicleIdPlacePickUpNavigation { get; set; }
        public virtual StatusVehicle StatusVehicleIdNavigation { get; set; }
    }
}
