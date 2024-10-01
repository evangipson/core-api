namespace CoreApi.Platform.Domain.Models
{
    public class Car : Vehicle
    {
        public bool HasLeatherSeats { get; set; }

        public float MilesPerGallon { get; set; }
    }
}
