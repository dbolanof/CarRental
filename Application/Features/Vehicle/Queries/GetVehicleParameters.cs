using Application.Parameters;

namespace Application.Features.Vehicle.Queries
{
    public class GetVehicleParameters : RequestParameter
    {
        public short Status { get; set; }
        public int PlacePickUp{ get; set; }
        public int PlaceDelivery{ get; set; }
    }
}
