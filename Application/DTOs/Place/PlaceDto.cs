namespace Application.DTOs.Place
{
    public class PlaceDto
    {
        public int IdPlace { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
