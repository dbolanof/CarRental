namespace Application.DTOs.StatusVehicle
{
    public class StatusVehicleDto
    {
        public short IdStatusVehicle { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
